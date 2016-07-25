using Contoso.Events.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Contoso.Events.Data
{
    public class EventsContextInitializer : CreateDatabaseIfNotExists<EventsContext>
    {
        protected override void Seed(EventsContext context)
        {
            context.Events.AddRange(
                new List<Event> 
                {
                    new Event
                    {
                      EventKey = "FY16OctGeneralConference",
                      StartTime = new DateTime(2016, 10, 8, 11, 52, 00),
                      EndTime = new DateTime(2016, 10, 11, 11, 52, 00),
                      Title = "FY16 October General Conferece",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 22
                    },
                    new Event
                    {
                      EventKey = "FY18FebTechnicalConference",
                      StartTime = new DateTime(2018, 2, 13, 5, 28, 00),
                      EndTime = new DateTime(2018, 2, 17, 5, 28, 00),
                      Title = "FY18 February Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 27
                    },
                    new Event
                    {
                      EventKey = "FY20MayTechnicalConference",
                      StartTime = new DateTime(2020, 5, 20, 3, 34, 00),
                      EndTime = new DateTime(2020, 5, 24, 3, 34, 00),
                      Title = "FY20 May Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 41
                    },
                    new Event
                    {
                      EventKey = "FY18AugInternalConference",
                      StartTime = new DateTime(2018, 8, 7, 3, 43, 00),
                      EndTime = new DateTime(2018, 8, 11, 3, 43, 00),
                      Title = "FY18 August Internal Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 5
                    },
                    new Event
                    {
                      EventKey = "FY16SepTechnicalConference",
                      StartTime = new DateTime(2016, 9, 13, 1, 31, 00),
                      EndTime = new DateTime(2016, 9, 17, 1, 31, 00),
                      Title = "FY16 September Technical Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 27
                    },
                    new Event
                    {
                      EventKey = "FY15AprGeneralConference",
                      StartTime = new DateTime(2015, 4, 12, 4, 52, 00),
                      EndTime = new DateTime(2015, 4, 16, 4, 52, 00),
                      Title = "FY15 April General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 9
                    },
                    new Event
                    {
                      EventKey = "FY18MarGeneralConference",
                      StartTime = new DateTime(2018, 3, 22, 11, 08, 00),
                      EndTime = new DateTime(2018, 3, 25, 11, 08, 00),
                      Title = "FY18 March General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 23
                    },
                    new Event
                    {
                      EventKey = "FY17OctInternalConference",
                      StartTime = new DateTime(2017, 10, 27, 6, 13, 00),
                      EndTime = new DateTime(2017, 10, 31, 6, 13, 00),
                      Title = "FY17 October Internal Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 36
                    },
                    new Event
                    {
                      EventKey = "FY19SepGeneralConference",
                      StartTime = new DateTime(2019, 9, 3, 9, 14, 00),
                      EndTime = new DateTime(2019, 9, 6, 9, 14, 00),
                      Title = "FY19 September General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 25
                    },
                    new Event
                    {
                      EventKey = "FY15DecGeneralConference",
                      StartTime = new DateTime(2015, 12, 15, 7, 09, 00),
                      EndTime = new DateTime(2015, 12, 19, 7, 09, 00),
                      Title = "FY15 December General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 34
                    },
                    new Event
                    {
                      EventKey = "FY15AugTechnicalConference",
                      StartTime = new DateTime(2015, 8, 20, 6, 06, 00),
                      EndTime = new DateTime(2015, 8, 24, 6, 06, 00),
                      Title = "FY15 August Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 23
                    },
                    new Event
                    {
                      EventKey = "FY15JulGeneralConference",
                      StartTime = new DateTime(2015, 7, 22, 5, 06, 00),
                      EndTime = new DateTime(2015, 7, 26, 5, 06, 00),
                      Title = "FY15 July General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 54
                    },
                    new Event
                    {
                      EventKey = "FY16DecTechnicalConference2",
                      StartTime = new DateTime(2016, 12, 4, 9, 59, 00),
                      EndTime = new DateTime(2016, 12, 7, 9, 59, 00),
                      Title = "FY16 December Technical Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 10
                    },
                    new Event
                    {
                      EventKey = "FY20JunGeneralConference",
                      StartTime = new DateTime(2020, 6, 20, 7, 16, 00),
                      EndTime = new DateTime(2020, 6, 24, 7, 16, 00),
                      Title = "FY20 June General Conferece",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 38
                    },
                    new Event
                    {
                      EventKey = "FY18SepSalesConference",
                      StartTime = new DateTime(2018, 9, 9, 11, 38, 00),
                      EndTime = new DateTime(2018, 9, 12, 11, 38, 00),
                      Title = "FY18 September Sales Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 38
                    }
                }
            );
        }
    }
}