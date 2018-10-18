# :construction_worker: Implementation Details #

## User Interface ##

The user interface is implemented using Angular 6.  The order of implementation for the screens is planned according to priorities set by the product owner.  The plan is documented in the [Milestone Plan](MILESTONES.md).

### CSS ###

The styling of the site is built on top of Bootstrap 4 CSS.  Angular 6 adds native support for animations.

### Widgets ###

It is not yet clear if a third party library such as Bootstrap widgets is necessary.  Also, the data tables planned for RockId may not need a lot of features (sort and pagination only).

## API ##

The back end is .NET Core 2 Web Api.

### QARP ###

Details about QARP may be found here ([QARP](QARP.md)).