import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-breadcrumb',
  templateUrl: './breadcrumb.component.html',
  styleUrls: ['./breadcrumb.component.css']
})
export class BreadcrumbComponent implements OnInit {  
  
  private _currentUrl = '';
  private _breadcrumbCollection;

  constructor(private router: Router) {     
  }

  ngOnInit() {
    this.router.events.forEach(event => {
      if (event instanceof NavigationEnd) {
        this._currentUrl = this.router.url;   
        let url_pruned = this._currentUrl.slice(1, this._currentUrl.length);
        this._breadcrumbCollection = this.createBreadcrumbCollectionByCurrentUrl(url_pruned);
        console.log(this._breadcrumbCollection);
      }
    });        
  }  

  // TOOO: define breadcrumbItem as specific type
  isActiveBreadcrumb(breadcrumbItem : any){
    return this._currentUrl === breadcrumbItem.pathFromRoot;
  }

  private getRouterConfigByBreadcrumbTitle(breadcrumbTitle : string){    
    let routerConfigs = this.router.config
      .filter( configElement => configElement.data && configElement.data.breadcrumbTitle === breadcrumbTitle);  
    return (routerConfigs && routerConfigs.length > 0) ? routerConfigs[0] : null;  
  }
 
  private getRouterConfigByUrl(url : string){    
    let routerConfigs = this.router.config
      .filter( configElement => configElement.path && configElement.path === url);
    return (routerConfigs && routerConfigs.length > 0) ? routerConfigs[0] : null;
  }

  private createBreadcrumbCollectionByCurrentUrl(currentUrl : string){
    let routerConfig = this.getRouterConfigByUrl(currentUrl);  
    let breadcrumbVm = [];
    let subRoutes = routerConfig.path.split('/');
    let pathFromRoot = '';
    for (let subRoute of subRoutes){
      pathFromRoot = (pathFromRoot.length > 0) ? pathFromRoot + '/' + subRoute : subRoute;
      let breadcrumbElement = {
        pathFromRoot: '/' + pathFromRoot,
        breadcrumbTitle: this.getRouterConfigByUrl(pathFromRoot).data.breadcrumbTitle
      };
      breadcrumbVm.push(breadcrumbElement);      
    }
    return breadcrumbVm;    
  }
}
