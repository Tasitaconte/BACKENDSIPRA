﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SIPRA_FESC.Utils.Swagger;
public class RemoveSchemasFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {

        IDictionary<string, OpenApiSchema> _remove = swaggerDoc.Components.Schemas;
        foreach (KeyValuePair<string, OpenApiSchema> _item in _remove)
        {
            swaggerDoc.Components.Schemas.Remove(_item.Key);
        }
    }
}
