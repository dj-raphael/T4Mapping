# DtoMapping
Generate extension methods for mapping DO models to DTO with t4 template
## Usage
1. Take 2 files [MapHelper.tt](https://github.com/dj-raphael/DtoMapping/blob/master/ConsoleApplicationParceAttribute/T4%20Folder/MapHelper.tt), [VisualStudioHelper.tt](https://github.com/dj-raphael/DtoMapping/blob/master/ConsoleApplicationParceAttribute/T4%20Folder/VisualStudioHelper.tt)
2. Create Attributes Map and MapIgnore
3. Create own template with options like [MappingExtension.tt](https://github.com/dj-raphael/DtoMapping/blob/master/ConsoleApplicationParceAttribute/T4%20Folder/MappingExtension.tt)

## Options
``` c#
MapHelper.MapExtensionNameSpace = "ConsoleApplicationParceAttribute";
MapHelper.MapExtensionClassName = "MapExtensionsViewModel"; 
MapHelper.MapAttribute = "Map"               // Map Attribute name
MapHelper.MapIgnoreAttribute = "MapIgnore";  // Ignore field Attribute name
MapHelper.DtoSuffix = "Dto";                 // suffix for DTO classes - ignored when compare
MapHelper.DoSuffix = "ViewModel";            // suffix for DO classes - ignored when compare
MapHelper.DoProjects.Add("DataObject");      // list of projects with DO classes
MapHelper.DtoProjects.Add("DataTransferObject");  // list of projects with DTO classes
```
Example output mapping methods see [here](https://github.com/dj-raphael/DtoMapping/blob/master/ConsoleApplicationParceAttribute/T4%20Folder/MappingExtension.g.cs)

you can map objects with code
``` c#
var dtoObj = doObj.MaptToDto();
```
