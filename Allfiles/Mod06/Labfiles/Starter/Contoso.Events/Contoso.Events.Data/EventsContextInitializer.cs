using Contoso.Events.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Contoso.Events.Data
{
    public class EventsContextInitializer : DropCreateDatabaseIfModelChanges<EventsContext>
    {
        protected override void Seed(EventsContext context)
        {
            context.Events.AddRange(
                new List<Event>
                {
                    new Event
                    {
                      EventKey = "FY17SepGeneralConference",
                      StartTime = DateTime.Parse("9/7/2017 3:40:00 PM"),
                      EndTime = DateTime.Parse("9/11/2017 3:40:00 AM"),
                      Title = "FY17 September Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 21
                    },
                    new Event
                    {
                      EventKey = "FY20MayGeneralConference",
                      StartTime = DateTime.Parse("5/16/2020 11:34:00 AM"),
                      EndTime = DateTime.Parse("5/19/2020 11:34:00 PM"),
                      Title = "FY20 May Sales Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 22
                    },
                    new Event
                    {
                      EventKey = "FY20AprGeneralConference",
                      StartTime = DateTime.Parse("4/1/2020 9:46:00 PM"),
                      EndTime = DateTime.Parse("4/5/2020 9:46:00 AM"),
                      Title = "FY20 April General Conferece",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 13
                    },
                    new Event
                    {
                      EventKey = "FY19MayGeneralConference",
                      StartTime = DateTime.Parse("5/24/2019 2:22:00 PM"),
                      EndTime = DateTime.Parse("5/28/2019 2:22:00 AM"),
                      Title = "FY19 May Internal Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 5
                    },
                    new Event
                    {
                      EventKey = "FY19SepGeneralConference",
                      StartTime = DateTime.Parse("9/2/2019 8:26:00 PM"),
                      EndTime = DateTime.Parse("9/6/2019 8:26:00 AM"),
                      Title = "FY19 September Internal Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 14
                    },
                    new Event
                    {
                      EventKey = "FY17JulGeneralConference",
                      StartTime = DateTime.Parse("7/17/2017 5:37:00 PM"),
                      EndTime = DateTime.Parse("7/21/2017 5:37:00 AM"),
                      Title = "FY17 July Internal Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 8
                    },
                    new Event
                    {
                      EventKey = "FY15FebGeneralConference",
                      StartTime = DateTime.Parse("2/5/2015 12:29:00 PM"),
                      EndTime = DateTime.Parse("2/9/2015 12:29:00 AM"),
                      Title = "FY15 February Sales Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 8
                    },
                    new Event
                    {
                      EventKey = "FY18MayGeneralConference",
                      StartTime = DateTime.Parse("5/3/2018 11:25:00 AM"),
                      EndTime = DateTime.Parse("5/6/2018 11:25:00 PM"),
                      Title = "FY18 May Sales Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 6
                    },
                    new Event
                    {
                      EventKey = "FY18AugGeneralConference",
                      StartTime = DateTime.Parse("8/18/2018 10:17:00 AM"),
                      EndTime = DateTime.Parse("8/21/2018 10:17:00 PM"),
                      Title = "FY18 August Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 22
                    },
                    new Event
                    {
                      EventKey = "FY18OctGeneralConference",
                      StartTime = DateTime.Parse("10/27/2018 10:47:00 AM"),
                      EndTime = DateTime.Parse("10/30/2018 10:47:00 PM"),
                      Title = "FY18 October Internal Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 9
                    },
                    new Event
                    {
                      EventKey = "FY16JunGeneralConference",
                      StartTime = DateTime.Parse("6/18/2016 11:31:00 AM"),
                      EndTime = DateTime.Parse("6/21/2016 11:31:00 PM"),
                      Title = "FY16 June General Conferece",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 9
                    },
                    new Event
                    {
                      EventKey = "FY16MarGeneralConference",
                      StartTime = DateTime.Parse("3/4/2016 8:48:00 PM"),
                      EndTime = DateTime.Parse("3/8/2016 8:48:00 AM"),
                      Title = "FY16 March Sales Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 22
                    },
                    new Event
                    {
                      EventKey = "FY17MayGeneralConference",
                      StartTime = DateTime.Parse("5/26/2017 10:29:00 AM"),
                      EndTime = DateTime.Parse("5/29/2017 10:29:00 PM"),
                      Title = "FY17 May Technical Conference",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 22
                    },
                    new Event
                    {
                      EventKey = "FY15OctGeneralConference",
                      StartTime = DateTime.Parse("10/23/2015 7:04:00 PM"),
                      EndTime = DateTime.Parse("10/27/2015 7:04:00 AM"),
                      Title = "FY15 October Technical Conference",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      RegistrationCount = 17
                    },
                    new Event
                    {
                      EventKey = "FY18MayGeneralConference2",
                      StartTime = DateTime.Parse("5/8/2018 6:52:00 PM"),
                      EndTime = DateTime.Parse("5/12/2018 6:52:00 AM"),
                      Title = "FY18 May General Conferece",
                      Description = "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.",
                      RegistrationCount = 21
                    }
                }
            );

            context.Registrations.AddRange(
                new List<Registration>
                {
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Autumn",
                      LastName = "Prince",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Vinicio",
                      LastName = "Robles",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Nicholas",
                      LastName = "Rose",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Adam",
                      LastName = "Bjerregaard",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Freda",
                      LastName = "Conley",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Autumn",
                      LastName = "Prince",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Giovanni",
                      LastName = "Vera",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Demi",
                      LastName = "Vadeboncoeur",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Jibran",
                      LastName = "Quraishi",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Naowarat",
                      LastName = "Kurusarttra",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Rhonda",
                      LastName = "Hughes",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Jenny",
                      LastName = "Norgaard",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Brain",
                      LastName = "Dulaney",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Mayra",
                      LastName = "Stephenson",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Freda",
                      LastName = "Conley",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Demi",
                      LastName = "Vadeboncoeur",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Naiyana",
                      LastName = "Kunakorn",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Frederic",
                      LastName = "Towle",
                    },
                    new Registration
                    {
                      EventKey = "FY17SepGeneralConference",
                      FirstName = "Carlene",
                      LastName = "O'Neill",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Germain",
                      LastName = "Arenas",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Ireneo",
                      LastName = "Piccio",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Consuelo",
                      LastName = "Navarro",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Bellamy",
                      LastName = "Garnier",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Mayra",
                      LastName = "Stephenson",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Arnold",
                      LastName = "Valenti",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Rhonda",
                      LastName = "Hughes",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Den",
                      LastName = "Kojima",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Neandro",
                      LastName = "Baeza",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Viv",
                      LastName = "Pichardo",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Letha",
                      LastName = "Walls",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Iselda",
                      LastName = "Bahena",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Francesca",
                      LastName = "Lombardi",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Sonia",
                      LastName = "Harrison",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Jeanie",
                      LastName = "Sheppard",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Maya",
                      LastName = "Steele",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Abby",
                      LastName = "Burris",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Bellamy",
                      LastName = "Garnier",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Viv",
                      LastName = "Pichardo",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Demi",
                      LastName = "Vadeboncoeur",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Victoria",
                      LastName = "Gray",
                    },
                    new Registration
                    {
                      EventKey = "FY20MayGeneralConference",
                      FirstName = "Margo",
                      LastName = "Ayers",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Jeannette",
                      LastName = "Kjaer",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Sophia",
                      LastName = "Garner",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Anthony",
                      LastName = "Frizzell",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Rhonda",
                      LastName = "Hughes",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Gerson",
                      LastName = "Toro",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Sheldon",
                      LastName = "Comeaux",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Gordon",
                      LastName = "Fredrickson",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Ireneo",
                      LastName = "Piccio",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Corinne",
                      LastName = "Horn",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Rajab",
                      LastName = "Shammas",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Vaughn",
                      LastName = "Oquendo",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Rosie",
                      LastName = "Reeves",
                    },
                    new Registration
                    {
                      EventKey = "FY20AprGeneralConference",
                      FirstName = "Frederic",
                      LastName = "Towle",
                    },
                    new Registration
                    {
                      EventKey = "FY19MayGeneralConference",
                      FirstName = "Burnell",
                      LastName = "Plourde",
                    },
                    new Registration
                    {
                      EventKey = "FY19MayGeneralConference",
                      FirstName = "Rajab",
                      LastName = "Shammas",
                    },
                    new Registration
                    {
                      EventKey = "FY19MayGeneralConference",
                      FirstName = "Arnold",
                      LastName = "Valenti",
                    },
                    new Registration
                    {
                      EventKey = "FY19MayGeneralConference",
                      FirstName = "Francesca",
                      LastName = "Lombardi",
                    },
                    new Registration
                    {
                      EventKey = "FY19MayGeneralConference",
                      FirstName = "Demi",
                      LastName = "Vadeboncoeur",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Corinne",
                      LastName = "Horn",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Iselda",
                      LastName = "Bahena",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Lucas",
                      LastName = "Sondergaard",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Ethan",
                      LastName = "Rincon",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Rodrigo",
                      LastName = "Romani",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Patrick",
                      LastName = "Lorenzen",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Sophia",
                      LastName = "Garner",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Margo",
                      LastName = "Ayers",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Vaughn",
                      LastName = "Oquendo",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Autumn",
                      LastName = "Prince",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Jimmie",
                      LastName = "Turman",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Demi",
                      LastName = "Vadeboncoeur",
                    },
                    new Registration
                    {
                      EventKey = "FY19SepGeneralConference",
                      FirstName = "Vittoria",
                      LastName = "Mancini",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Consuelo",
                      LastName = "Navarro",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Abbi",
                      LastName = "Byrne",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Jeannette",
                      LastName = "Kjaer",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Delmar",
                      LastName = "Pelchat",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Dwayne",
                      LastName = "Passmore",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Francine",
                      LastName = "Fischer",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Consuelo",
                      LastName = "Navarro",
                    },
                    new Registration
                    {
                      EventKey = "FY17JulGeneralConference",
                      FirstName = "Neandro",
                      LastName = "Baeza",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Germain",
                      LastName = "Arenas",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Erembourg",
                      LastName = "Ratte",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Agnano",
                      LastName = "Brito",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Aisha",
                      LastName = "Witt",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Janna",
                      LastName = "Gamble",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Giovanni",
                      LastName = "Vera",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Jeanne",
                      LastName = "Vestergaard",
                    },
                    new Registration
                    {
                      EventKey = "FY15FebGeneralConference",
                      FirstName = "Lonnie",
                      LastName = "Schindler",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference",
                      FirstName = "Erembourg",
                      LastName = "Ratte",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference",
                      FirstName = "Neandro",
                      LastName = "Baeza",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference",
                      FirstName = "Carey",
                      LastName = "Merrill",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference",
                      FirstName = "Jeanie",
                      LastName = "Sheppard",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference",
                      FirstName = "Roman",
                      LastName = "Pilcher",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Gordon",
                      LastName = "Fredrickson",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Jeannette",
                      LastName = "Kjaer",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Abdul-Alim",
                      LastName = "Mikhail",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Vicky",
                      LastName = "Erickson",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Brain",
                      LastName = "Dulaney",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Abdul-Alim",
                      LastName = "Mikhail",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Zachary",
                      LastName = "Fellows",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Generosa",
                      LastName = "Esposito",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Rocco",
                      LastName = "Yarborough",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Lucas",
                      LastName = "Sondergaard",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Chad",
                      LastName = "Corbitt",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Jennifer",
                      LastName = "Davey",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Naomi",
                      LastName = "Sharp",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Ethan",
                      LastName = "Rincon",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Kari",
                      LastName = "Tran",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Ireneo",
                      LastName = "Piccio",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Lucas",
                      LastName = "Sondergaard",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Maya",
                      LastName = "Steele",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Francesca",
                      LastName = "Lombardi",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Kari",
                      LastName = "Tran",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Roman",
                      LastName = "Pilcher",
                    },
                    new Registration
                    {
                      EventKey = "FY18AugGeneralConference",
                      FirstName = "Jeanne",
                      LastName = "Vestergaard",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Janna",
                      LastName = "Gamble",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Sheldon",
                      LastName = "Comeaux",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Nelida",
                      LastName = "Zamora",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Noreen",
                      LastName = "Branch",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Francesca",
                      LastName = "Lombardi",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Iselda",
                      LastName = "Bahena",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Zachary",
                      LastName = "Fellows",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Neandro",
                      LastName = "Baeza",
                    },
                    new Registration
                    {
                      EventKey = "FY18OctGeneralConference",
                      FirstName = "Bellamy",
                      LastName = "Garnier",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Abbi",
                      LastName = "Byrne",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Nickolas",
                      LastName = "McLaughlin",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Jimmie",
                      LastName = "Turman",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Brain",
                      LastName = "Dulaney",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Kian",
                      LastName = "Goddard",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Fabio",
                      LastName = "Jaramillo",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Victoria",
                      LastName = "Holloway",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Elwood",
                      LastName = "McGee",
                    },
                    new Registration
                    {
                      EventKey = "FY16JunGeneralConference",
                      FirstName = "Alaine",
                      LastName = "Poisson",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Patrick",
                      LastName = "Lorenzen",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Alaine",
                      LastName = "Poisson",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Mara",
                      LastName = "Rasmussen",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Lonnie",
                      LastName = "Schindler",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Rhonda",
                      LastName = "Hughes",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Victoria",
                      LastName = "Gray",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Eleanor",
                      LastName = "Bryan",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Aaliyah",
                      LastName = "Briggs",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Janna",
                      LastName = "Gamble",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Alaine",
                      LastName = "Poisson",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Fabio",
                      LastName = "Jaramillo",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Dan",
                      LastName = "Drayton",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Germain",
                      LastName = "Arenas",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Aisha",
                      LastName = "Witt",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Jeanie",
                      LastName = "Sheppard",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Modesto",
                      LastName = "Cabán",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Neandro",
                      LastName = "Baeza",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Naiyana",
                      LastName = "Kunakorn",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Patrick",
                      LastName = "Lorenzen",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Letha",
                      LastName = "Walls",
                    },
                    new Registration
                    {
                      EventKey = "FY16MarGeneralConference",
                      FirstName = "Rocco",
                      LastName = "Yarborough",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Bellamy",
                      LastName = "Garnier",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Arnold",
                      LastName = "Valenti",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Janna",
                      LastName = "Gamble",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Jenny",
                      LastName = "Norgaard",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Margret",
                      LastName = "Villarreal",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Armen",
                      LastName = "Romo",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Deanna",
                      LastName = "Ball",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Freda",
                      LastName = "Conley",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Demi",
                      LastName = "Vadeboncoeur",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Jimmie",
                      LastName = "Turman",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Vaughn",
                      LastName = "Oquendo",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Ireneo",
                      LastName = "Piccio",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Dwayne",
                      LastName = "Passmore",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Letha",
                      LastName = "Walls",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Joann",
                      LastName = "Chambers",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Ansel",
                      LastName = "Loiselle",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Jibran",
                      LastName = "Quraishi",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Abby",
                      LastName = "Burris",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Letha",
                      LastName = "Walls",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Marva",
                      LastName = "Cardenas",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Margo",
                      LastName = "Ayers",
                    },
                    new Registration
                    {
                      EventKey = "FY17MayGeneralConference",
                      FirstName = "Victoria",
                      LastName = "Gray",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Gordon",
                      LastName = "Fredrickson",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Corinne",
                      LastName = "Horn",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Jeannette",
                      LastName = "Kjaer",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Jensigne",
                      LastName = "Carlsen",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Abdul-Alim",
                      LastName = "Mikhail",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Arnold",
                      LastName = "Valenti",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Jeannette",
                      LastName = "Kjaer",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Abdul-Alim",
                      LastName = "Mikhail",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Rodrigo",
                      LastName = "Romani",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Aisha",
                      LastName = "Witt",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Rosie",
                      LastName = "Reeves",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Abdul-Alim",
                      LastName = "Mikhail",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Ireneo",
                      LastName = "Piccio",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Nickolas",
                      LastName = "McLaughlin",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Nicholas",
                      LastName = "Rose",
                    },
                    new Registration
                    {
                      EventKey = "FY15OctGeneralConference",
                      FirstName = "Fabio",
                      LastName = "Jaramillo",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Viv",
                      LastName = "Pichardo",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Bellamy",
                      LastName = "Garnier",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Jenny",
                      LastName = "Norgaard",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Bellamy",
                      LastName = "Garnier",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Naowarat",
                      LastName = "Kurusarttra",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Naowarat",
                      LastName = "Kurusarttra",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Erik",
                      LastName = "Collado",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Armen",
                      LastName = "Romo",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Joann",
                      LastName = "Chambers",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Consuelo",
                      LastName = "Navarro",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Delmar",
                      LastName = "Pelchat",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Lucas",
                      LastName = "Sondergaard",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Amalio",
                      LastName = "Pizarro",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Jeanne",
                      LastName = "Vestergaard",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Daitaro",
                      LastName = "Ishida",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Adam",
                      LastName = "Bjerregaard",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Jeanette",
                      LastName = "Frandsen",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Vittoria",
                      LastName = "Mancini",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Naiyana",
                      LastName = "Kunakorn",
                    },
                    new Registration
                    {
                      EventKey = "FY18MayGeneralConference2",
                      FirstName = "Lonnie",
                      LastName = "Schindler",
                    }
                }
            );

            context.SaveChanges();
        }
    }
}
