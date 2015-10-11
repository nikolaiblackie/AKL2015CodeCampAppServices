# Auckland 2015 Code Camp Azure AppServices

Code camp Auckland 2015 Samples - DEV1 – How to Design, Build, Deploy and Manage API’s in Microsoft Azure

## Slides
All slides from presentation

https://github.com/nikolaiblackie/AKL2015CodeCampAppServices/blob/master/Main/Code%20Camp%20AKL%202015%20-%20DEV1%20Microsoft%20API%20Approaches%20101.pdf

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

# Resources
Where to find more information on Azure App Services (API Apps, Logic Apps), TFS 2015 Builds, Swagger

## API Apps

* API Apps Documentation : https://azure.microsoft.com/en-in/documentation/articles/app-service-api-apps-why-best-platform/


## Swagger

* Swashbuckle : https://github.com/domaindrivendev/Swashbuckle
* ASP NET WebAPI documentation using Swagger : http://bitoftech.net/2014/08/25/asp-net-web-api-documentation-using-swagger/
* Swashbuckle Customization: https://azure.microsoft.com/en-us/documentation/articles/app-service-api-dotnet-swashbuckle-customize/
* Swagger & ASP NET WebAPI: http://www.wmpratt.com/swagger-and-asp-net-web-api-part-1/

## TFS 2015 Builds
* Team Foundation Build 2015: https://msdn.microsoft.com/Library/vs/alm/Build/overview
* Visual Studio Online DevOps Tasks: https://github.com/Microsoft/vso-agent-tasks/blob/master/README.md 

## Logic App

* Logic App EAI Tutorial : https://azure.microsoft.com/en-us/documentation/articles/app-service-logic-create-a-logic-app/
* Author Logic App definitions : https://azure.microsoft.com/en-gb/documentation/articles/app-service-logic-author-definitions/
* Logic App Workflow Definition Language : https://msdn.microsoft.com/en-us/library/azure/dn948512.aspx
* Logic App Workflow Actions and Triggers : https://msdn.microsoft.com/en-us/library/azure/dn948511.aspx
* Logic App Management API : https://msdn.microsoft.com/en-US/library/azure/dn948513.aspx
* Logic Apps Documentation : https://azure.microsoft.com/en-in/documentation/articles/app-service-logic-what-are-logic-apps/
