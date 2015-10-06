using System;
using System.Reflection;

namespace AdtvDemo.WUS.WebAPI.Logistics.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}