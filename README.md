# Keycloak.Client

[![license](https://img.shields.io/github/license/nagybalint001/Keycloak.Client.svg?maxAge=2592000)](https://github.com/nagybalint001/Keycloak.Client/blob/main/LICENSE) [![NuGet](https://img.shields.io/nuget/v/Keycloak.Client.svg?maxAge=2592000)](https://www.nuget.org/packages/Keycloak.Client/) ![downloads](https://img.shields.io/nuget/dt/Keycloak.Client)

HttpClient wrapper for Keycloak API

> [!NOTE]
> Keycloak Admin REST API has an OpenAPI definition (https://www.keycloak.org/docs-api/latest/rest-api/openapi.json), but it is still not perfect (e.g. operation IDs are missing),
> so automatic code generation is not feasible at the moment. https://github.com/keycloak/keycloak/discussions/8898
> Once this PR (https://github.com/keycloak/keycloak/pull/39011) is merged, it is worth to check code generation e.g. NSwag.