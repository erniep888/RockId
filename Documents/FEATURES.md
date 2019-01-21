# :page_with_curl: RockId Feature List #
  
## Description ##

This document serves as the feature list that makes up the RockId application. The primary business stakeholder should review this list to confirm that all relevant business problems are identified and satisfactory resolved by feature. The primary technical owner should review this list to confirm that sufficient details are clearly documented in order to estimate, implement, and test each feature.

## 1.0 Feature List ##

1. User Security
** ***Detail:*** All users must be known to the system.
** ***Solution:***
*** Anonymous user access is denied.
*** All users must login in with an email address
*** All users have a password that is 8 to 32 characters long and alphanumeric with special characters.
2. Display All Rocks Identified
    * ***Detail:*** All rocks that have been identified should be visible to all other authenticated users.
    * ***Solution:***
      * Once a rock has been successfully identified, it will be displayed in a list displayed in the order of completion date.
      * All identified rocks will be displayed in one page.
3. Display All Action History
    * ***Detail:*** All actions are tracked and displayed for all authenticated users.
    * ***Solution:***
      * The following actions are tracked:
        * Login
        * Logout
        * Rock identified
        * User added
      * All actions will be displayed in one page.
4. Identify Rock
    * ***Detail:*** An authenticated user can step through the process to identify a rock.
    * ***Solution:***
      * For 1.0, this feature only implements identification of glassy and fine-grained rocks. The authenticated user will answer questions to identity the rock.
      * What is the grain size?
      * Glassy (no visible grains)
        * Is it light or dark?
          * Light is Igneous - Quartz.
          * Dark is Igneous - Obsidian
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
