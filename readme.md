# Sitecore.Support.145188
There is a new way of handling exceptions on mvc renderings. The defined types of exceptions can be wrapped into special class ExceptionWrapper. Later the exceptions should be processed by handlers. There is an issue related to the rendering of exception in case it has been wrapped previously. Inner exceptions are not shown more. This patch allows to display inner exceptions.

## License  
This patch is licensed under the [Sitecore Corporation A/S License for GitHub](https://github.com/sitecoresupport/Sitecore.Support.145188/blob/master/LICENSE).  

## Download  
Downloads are available via [GitHub Releases](https://github.com/sitecoresupport/Sitecore.Support.145188/releases).  

[![Github All Releases](https://img.shields.io/github/downloads/SitecoreSupport/Sitecore.Support.145188/total.svg)](https://github.com/SitecoreSupport/Sitecore.Support.145188/releases)
