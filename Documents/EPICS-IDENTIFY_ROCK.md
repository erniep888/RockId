# RockId Epics - Identify Rock (QARP) #

## Description ##

An authenticated user can step through the process to identify a rock.

## Solution ##

* For 1.0, this feature only implements identification of glassy and fine-grained rocks. The authenticated user will answer questions to identity the rock.
* What is the grain size?
* Glassy (no visible grains)
  * Is it light or dark?
    * Light is Igneous - Quartz.
    * Dark is Igneous - Obsidian.
* Fine Grained (not easy to see grains)
  * Can the rock be stratched by a knife?
    * Yes, and it is dense and brittle - Sedimentary - Chert.
    * No
      * Is it light in color?
        * Yes, with glossy grains - Metamorphic - Quartzite.
        * Yes, with dull grains - Igneous - Felsite.
        * No
          * Is it medium in color?
            * Yes - Igneous - Andesite.
            * No - It is dark in color.
              * Does it fizz with acid?
                * Yes, vigorously - Sedimentary - Limestone.
                * Yes, with difficulty or with rock powder - Sedimentary - Dolomite.
                * No
                  * Does it have layers?
                    * Yes, it splits easily into thin smooth sheets - Metamorphic - Slate
                    * Yes, it does not split easily - Metamorphic - Shale
                    * No, it does have slippery feel colored green to black - Metamorphic - Serpentine
* Mixed Fine and Coarse
  * Not in release 1.0
* Medium to Coarse
  * Not in release 1.0

## Epics -> Stories ##

* Epic #8 : (13) : Create the reusable components of the question, answer, and result process (QARP)
  * :heavy_check_mark: Story #17 : (3) : As a developer, I need to research and document the implementation strategy for the question, answer, and result process (QARP).
  * Story #18 : (2) : As a developer, I need to create the tables required for QARP.
  * :heavy_check_mark: Story #19 : (2) : As a user, I need to be asked about the grain size within the rock as the first question.
  * Story #31 : (1) : As a user, I want to know that Mixed Fine and Coarse grained and Medium to Coarse grained are not yet implemented.
* Epic #9 : (5) : Implement the Glassy grain size
  * Story #20 : (2) : As a user, I need to identify Quartz.
  * Story #21 : (2) : As a user, I need to identify Obsidian.
* Epic #10 : (20) : Implement the Fined Grained size
  * Story #22 : (1) : As a user, I need to identify Chert.
  * Story #23 : (2) : As a user, I need to identify Quartzite.
  * Story #24 : (0.5) : As a user, I need to identify Felsite.
  * Story #25 : (2) : As a user, I need to identify Andesite.
  * Story #26 : (1) : As a user, I need to identify Limestone.
  * Story #27 : (0.5) : As a user, I need to identify Dolomite.
  * Story #28 : (1) : As a user, I need to identify Slate.
  * Story #29 : (0.5) : As a user, I need to identify Shale.
  * Story #30 : (0.5) : As a user, I need to identify Serpentine.

## Screenshots ##

![What is the Grain Size?](https://github.com/erniep888/RockId/blob/master/Documents/screenshots/IdentifyNewRock-0.3.0.png?raw=true)

## Wire Frames ##

![What is the Grain Size?](https://github.com/erniep888/RockId/blob/master/Documents/wireframe-png/Identify%20Rock-GrainSize.png?raw=true)
![Can the rock be scratched by a knife?](https://github.com/erniep888/RockId/blob/master/Documents/wireframe-png/Identify%20Rock-Scratched.png?raw=true)
![Is it light in color?](https://github.com/erniep888/RockId/blob/master/Documents/wireframe-png/Identify%20Rock-LightColor.png?raw=true)
![Felsite Result](https://github.com/erniep888/RockId/blob/master/Documents/wireframe-png/Identify%20Rock-Felsite.png?raw=true)