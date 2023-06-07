# Magic AutoMapper
Helper to automatic configure mappings with Automapper

## What is Magic AutoMapper?

When we work with AutoMapper in a project normally we have an flat and basic profiles to configure maps like ```csharp Mapper.Map<entity,entityDto>();``` where all properties of DTO type are equals (type and name) than source entity.

Magic AutoMapper simplify the way to configure this maps without need create a especific profiles. Maps will be defined into Dto class declaration.

You only need do something like this, **Magic Automapper** works for you:
```csharp 
using Magic.AutoMapper;
    
public class EntityDto : IMapFrom<Entity>
{
    public int Id { get; set; }
    public string DataName { get; set; }
}

```



This library is based on an original idea of Jason Taylor, exposed in NDC Sydney 2019 conference.

## Getting Started

*Comming Soon*


## Acknowledgements

* [Json Taylor](https://jasontaylor.dev/)
* [ASP.NET Core](https://github.com/aspnet)
* [XUnit](https://xunit.github.io/)
* [Fluent Assertions](http://www.fluentassertions.com/)

## Code of conduct
This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
