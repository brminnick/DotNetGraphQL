[![Build Solution](https://github.com/brminnick/DotNetGraphQL/actions/workflows/main.yml/badge.svg)](https://github.com/brminnick/DotNetGraphQL/actions/workflows/main.yml)

# GraphQL in .NET

If you're new to GraphQL, check out these videos featured in the [Learn More](#learn-more) section, below
- [Learning GraphQL Series](#learning-graphql-series)
- [Xamarin + GraphQL](#xamarin--graphql)
- On .NET Show, Channel 9
  - [Introduction to GraphQL](https://docs.microsoft.com/shows/on-net/introduction-to-graphql?WT.mc_id=dotnetgraphql-codetraveler-bramin)
  - [Creating a GraphQL Backend in C#](https://docs.microsoft.com/shows/on-net/creating-a-graphql-backend?WT.mc_id=dotnetgraphql-codetraveler-bramin)
  - [Consuming GraphQL in C#](https://docs.microsoft.com/shows/on-net/consuming-graphql-in-c?WT.mc_id=dotnetgraphql-codetraveler-bramin)

To run this sample, follow the [Getting Started Instructions, below](#getting-started).

This app was featured at [GraphQL Summit 2019](https://codetraveler.io/GraphQLSummit-DotNet). 

## Video Recordings

### Consuming GraphQL in C#

This session on GraphQL + C# was delivered at [GraphQL Summit 2019](https://codetraveler.io/GraphQLSummit-DotNet).  It demonstrates how to create a GraphQL Backend in C# and connect it to a client-side mobile app written in C# using Xamarin.

[![Consuming GraphQL in C#](https://user-images.githubusercontent.com/13558917/68418928-17682700-014e-11ea-9aa6-749254cb50fe.png)](https://youtu.be/t1cQsenAmNo?t=18575)

### Xamarin + GraphQL

The session on Xamarin + GraphQL was delivered at [Xamarin Developer Summit 2019](https://www.codetraveler.io/xamdevsummit-graphql/). It demonstrates how to create a Xamarin app in C# and connect it to an existing GraphQL Backend.

[![Xamarin + GraphQL Video](https://user-images.githubusercontent.com/13558917/61256668-6a8f1780-a722-11e9-97ad-8188ec6eab8f.png)](https://channel9.msdn.com/Events/Xamarin/Xamarin-Developer-Summit-2019/XamarinGraphQL?WT.mc_id=mobile-0000-bramin)

### Learning GraphQL Series

This special series teaches the basics of GraphQL, how to interact with an existing GraphQL endpoint, how to create your first GraphQL Server, and how to deploy your GraphQL Server to the cloud using Azure! 

[![Learning GraphQL Series](https://learn.microsoft.com/en-us/shows/graphql/media/1854de91-affc-4a02-8a0c-a0f112e18b62.png)](https://learn.microsoft.com/shows/graphql?WT.mc_id=mobile-0000-bramin)

### On .NET Show

In this series, we cover how to create an end-to-end soolution, creating GraphQL Backend in C# and connecting to it from a C# client.

- [Introduction to GraphQL](https://docs.microsoft.com/shows/on-net/introduction-to-graphql?WT.mc_id=dotnetgraphql-codetraveler-bramin)
- [Creating a GraphQL Backend in C#](https://docs.microsoft.com/shows/on-net/creating-a-graphql-backend?WT.mc_id=dotnetgraphql-codetraveler-bramin)
- [Consuming GraphQL in C#](https://docs.microsoft.com/shows/on-net/consuming-graphql-in-c?WT.mc_id=dotnetgraphql-codetraveler-bramin)

[![On .NET Show](https://user-images.githubusercontent.com/13558917/76797023-df22c600-6789-11ea-8595-99f90df499a9.png)](https://docs.microsoft.com/shows/on-net/?WT.mc_id=mobile-0000-bramin)

## App Architecture 

### GraphQL Backend
The GraphQL backend is created in C# using the [GraphQL NuGet Package](https://www.nuget.org/packages/GraphQL/).

| GraphiQL |
| -------- |
| ![GraphiQL](https://user-images.githubusercontent.com/13558917/67914743-3a8f4700-fb4e-11e9-936d-320dfdd5d874.png) |

### Mobile
The mobile app is created in C# using [Xamarin](https://docs.microsoft.com/xamarin/cross-platform/?WT.mc_id=mobile-0000-bramin) and the [GraphQL.Client NuGet Package](https://www.nuget.org/packages/GraphQL.Client/).

| Xamarin.iOS | Xamarin.Android |
| ----------- | --------------- |
| <img src="https://user-images.githubusercontent.com/13558917/67914056-44b04600-fb4c-11e9-98ee-9d7ecb1bbc65.png" height="600"> | <img src="https://user-images.githubusercontent.com/13558917/67915040-16803580-fb4f-11e9-80c2-ae91a25f4e7b.png" height="550"> | 

## Getting Started

This app requires us to run the GraphQL API using the terminal while using Visual Studio to build/deploy the Xamarin.iOS and/or Xamarin.Android app.

### 1. Run the GraphQL API

1. Open the **terminal**
2. In the **terminal**, clone this solution by entering the following command:
    - **Note:** If you have already downloaded the solution, skip this step

```bash
git clone https://github.com/brminnick/dotnetgraphql.git
```

3. In the **terminal**, navigate to the `DotNetGraphQL.API` folder by entering the following command:

- On Windows

```bash
cd [path to DotNetGraphQL folder]\Source\DotNetGraphQL.API\
```
- On macOS
```bash
cd [path to DotNetGraphQL folder]/Source/DotNetGraphQL.API/
```

4. In the **terminal**, run `DotNetGraphQL.API.csproj` by entering the following command:

```bash
dotnet run
```

5. Open a web browser
6. In the web browser, navgiate to `http://localhost:4000`
7. Confirm GraphiQL

### 2. Run the Xamarin.Android App

1. In **Visual Studio**, open `DotNetGraphQL/Source/DotNetGraphQL.sln`
2. In **Visual Studio**, in the **Solution Explorer**, right-click on **DotNetGraphQL.Android**
3. In the right-click menu, select **Set as Startup Project**
4. In **Visual Studio**, build/deploy **DotNetGraphQL.Android** to an Android device
6. Confirm the list of dogs from the GraphQL API appears

# Learn More

Learn more about Xamarin + GraphQL

## Docs

### Xamarin Resources

- [Getting Started with Xamarin](https://docs.microsoft.com/xamarin/cross-platform/?WT.mc_id=mobile-0000-bramin)
- [Getting Started with Xamarin.Forms](https://docs.microsoft.com/xamarin/xamarin-forms?WT.mc_id=mobile-0000-bramin)
- [Install Visual Studio (PC) + Xamarin](https://docs.microsoft.com/xamarin/get-started/installation/windows?WT.mc_id=mobile-0000-bramin)
- [Install Visual Studio for Mac + Xamarin](https://docs.microsoft.com/visualstudio/mac/installation?view=vsmac-2019&WT.mc_id=mobile-0000-bramin)
- [Microsoft Learn: Build Mobile Apps With Xamarin.Forms](https://docs.microsoft.com/learn/paths/build-mobile-apps-with-xamarin-forms?WT.mc_id=mobile-0000-bramin)
- Xamarin Source Code
    - [Xamarin.iOS](https://github.com/xamarin/xamarin-macios)
    - [Xamarin.Android](https://github.com/xamarin/xamarin-android)
    - [Xamarin.Forms](https://github.com/xamarin/Xamarin.Forms)
    - [Mono](https://github.com/mono/mono)
    
### GraphQL Resources

- [GraphQL.org](https://graphql.org/)
- [Using Postman with GraphQL API](https://www.codetraveler.io/2019/01/12/how-to-use-postman-with-a-graphql-api/)
- [GraphQL for .NET](https://github.com/graphql-dotnet/graphql-dotnet)
- [GraphQL vs REST](https://philsturgeon.uk/api/2017/01/24/graphql-vs-rest-overview/)
- [GraphQL vs OData](https://jeffhandley.com/2018-09-13/graphql-is-not-odata)
- [Awesome GraphQL](https://github.com/chentsulin/awesome-graphql)
