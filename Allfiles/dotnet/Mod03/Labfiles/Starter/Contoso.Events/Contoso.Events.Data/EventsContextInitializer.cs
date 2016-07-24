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
                      StartTime = DateTime.Parse("10/8/2016 11:52:00 AM"),
                      EndTime = DateTime.Parse("10/11/2016 11:52:00 PM"),
                      Title = "FY16 October General Conferece",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 22
                    },
                    new Event
                    {
                      EventKey = "FY18FebTechnicalConference",
                      StartTime = DateTime.Parse("2/13/2018 5:28:00 PM"),
                      EndTime = DateTime.Parse("2/17/2018 5:28:00 AM"),
                      Title = "FY18 February Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 27
                    },
                    new Event
                    {
                      EventKey = "FY20MayTechnicalConference",
                      StartTime = DateTime.Parse("5/20/2020 3:34:00 PM"),
                      EndTime = DateTime.Parse("5/24/2020 3:34:00 AM"),
                      Title = "FY20 May Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 41
                    },
                    new Event
                    {
                      EventKey = "FY18AugInternalConference",
                      StartTime = DateTime.Parse("8/7/2018 3:43:00 PM"),
                      EndTime = DateTime.Parse("8/11/2018 3:43:00 AM"),
                      Title = "FY18 August Internal Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 5
                    },
                    new Event
                    {
                      EventKey = "FY16SepTechnicalConference",
                      StartTime = DateTime.Parse("9/13/2016 1:31:00 PM"),
                      EndTime = DateTime.Parse("9/17/2016 1:31:00 AM"),
                      Title = "FY16 September Technical Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 27
                    },
                    new Event
                    {
                      EventKey = "FY15AprGeneralConference",
                      StartTime = DateTime.Parse("4/12/2015 4:52:00 PM"),
                      EndTime = DateTime.Parse("4/16/2015 4:52:00 AM"),
                      Title = "FY15 April General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 9
                    },
                    new Event
                    {
                      EventKey = "FY18MarGeneralConference",
                      StartTime = DateTime.Parse("3/22/2018 11:08:00 AM"),
                      EndTime = DateTime.Parse("3/25/2018 11:08:00 PM"),
                      Title = "FY18 March General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 23
                    },
                    new Event
                    {
                      EventKey = "FY17OctInternalConference",
                      StartTime = DateTime.Parse("10/27/2017 6:13:00 PM"),
                      EndTime = DateTime.Parse("10/31/2017 6:13:00 AM"),
                      Title = "FY17 October Internal Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 36
                    },
                    new Event
                    {
                      EventKey = "FY19SepGeneralConference",
                      StartTime = DateTime.Parse("9/3/2019 9:14:00 AM"),
                      EndTime = DateTime.Parse("9/6/2019 9:14:00 PM"),
                      Title = "FY19 September General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 25
                    },
                    new Event
                    {
                      EventKey = "FY15DecGeneralConference",
                      StartTime = DateTime.Parse("12/15/2015 7:09:00 PM"),
                      EndTime = DateTime.Parse("12/19/2015 7:09:00 AM"),
                      Title = "FY15 December General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 34
                    },
                    new Event
                    {
                      EventKey = "FY15AugTechnicalConference",
                      StartTime = DateTime.Parse("8/20/2015 6:06:00 PM"),
                      EndTime = DateTime.Parse("8/24/2015 6:06:00 AM"),
                      Title = "FY15 August Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 23
                    },
                    new Event
                    {
                      EventKey = "FY15JulGeneralConference",
                      StartTime = DateTime.Parse("7/22/2015 5:06:00 PM"),
                      EndTime = DateTime.Parse("7/26/2015 5:06:00 AM"),
                      Title = "FY15 July General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 54
                    },
                    new Event
                    {
                      EventKey = "FY16DecTechnicalConference2",
                      StartTime = DateTime.Parse("12/4/2016 9:59:00 AM"),
                      EndTime = DateTime.Parse("12/7/2016 9:59:00 PM"),
                      Title = "FY16 December Technical Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 10
                    },
                    new Event
                    {
                      EventKey = "FY20JunGeneralConference",
                      StartTime = DateTime.Parse("6/20/2020 7:16:00 PM"),
                      EndTime = DateTime.Parse("6/24/2020 7:16:00 AM"),
                      Title = "FY20 June General Conferece",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 38
                    },
                    new Event
                    {
                      EventKey = "FY18SepSalesConference",
                      StartTime = DateTime.Parse("9/9/2018 11:38:00 AM"),
                      EndTime = DateTime.Parse("9/12/2018 11:38:00 PM"),
                      Title = "FY18 September Sales Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 38
                    }
                }
            );
        }
    }
}