Description
This plugin will help you to copy your favorite libraries to your projects

What LibraryDepot do:

    * Extract zip files to your src directory
    * Allow to place zip files in sub directories
    * Copy swc files to your lib directory

What LibraryDepot does NOT do:

    * Copy svn repositories
    * Keep treemenu synced with depot, FD restart needed


Thanks in advance to anyone who tries it out!
Remember : Use at your own risk


Tested on FlashDevelop versions:

    * 4.0 beta


Known Bugs/Issues

    * ???


Version History

    / 2.0.47 - July 8, 2011
      * copy sources to /classes/ if dir exists but no /src/
      
    / 2.0.42 - July 5, 2011
      * Update to v2 for FlashDevelop 4
      
    / 1.0.36 - January 6, 2011
      * change timer to FileSystemWatcher to update menu

    / 1.0.27 - January 5, 2011
      + add filter for library files, only swc, zip files show up in treemenu
      + add filters for zip extract
      + dialog at first run to select depot path
      * bug fix of treemenu refresh when library path setting changes

    / 1.0.5 - December 23, 2010
      + add support for SWC file
      * icon change
      
    / 1.0.1 - December 22, 2010
      - initial implementation of LibraryDepot