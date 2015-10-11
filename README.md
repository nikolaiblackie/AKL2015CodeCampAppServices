# AKL2015CodeCampAppServices

Code camp Auckland 2015 Samples - DEV1 – How to Design, Build, Deploy and Manage API’s in Microsoft Azure

## Slides

## Solution
* AdtvDemo.WUS.API.Orders
* AdtvDemo.WUS.API.Products
* AdtvDemo.WUS.WebAPI.Logistics
* LogicDefinition
* SoapUI

## Swagger

### Swagger Configuration
* Set project properties XML documentation file ‘bin\XmlComments.xml’
* Update SwaggerConfig IncludeXmlComments to string.Format(@"{0}\bin\XmlComments.xml", System.AppDomain.CurrentDomain.BaseDirectory)

### WebAPI Swagger via web app URL
* /swagger/ui/index – UI documentation
* /swagger/docs/v1 – Swagger DOC

### API App Swagger 
* Download swagger 
* API Host URL + /swagger/docs/v1 – Swagger DOC

## TFS 2015 Visual Studio Builds 
### MSBuild Arguments to support web deployment
* /p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=true /p:SkipInvalidConfigurations=true /p:PackageLocation="$(build.stagingDirectory)"
### Deploy automatically to slots or live - Web Deploy Package (based on MSBuild Arguments)
* $(build.stagingDirectory)\**\AdtvDemo.WUS.WebAPI.Logistics.zip
* $(build.stagingDirectory)\**\AdtvDemo.WUS.API.Products.zip
