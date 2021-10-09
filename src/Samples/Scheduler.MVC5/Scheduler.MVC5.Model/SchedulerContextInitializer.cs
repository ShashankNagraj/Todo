using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Scheduler.MVC5.Model.Models;
namespace Scheduler.MVC5.Model
{
    class SchedulerContextInitializer : DropCreateDatabaseAlways<SchedulerContext>
    {
        protected override void Seed(SchedulerContext context)
        {


            context.ColoredEvents.AddRange(new List<ColoredEvent>{ 
                new ColoredEvent{ id = 6, text = "New event", start_date = new DateTime(2017, 09, 09, 06, 25, 00), end_date = new DateTime(2017, 09, 09, 06, 30, 00), color = "#76B007", room_id = null }, 
                new ColoredEvent{ id = 7, text = "New event", start_date = new DateTime(2017, 09, 05, 06, 30, 00), end_date = new DateTime(2017, 09, 05, 06, 35, 00), color = "#ccc", room_id = null }, 
                new ColoredEvent{ id = 8, text = "New event", start_date = new DateTime(2017, 09, 09, 03, 55, 00), end_date = new DateTime(2017, 09, 09, 04, 00, 00), color = "#ccc", room_id = null }, 
                new ColoredEvent{ id = 9, text = "New event", start_date = new DateTime(2017, 09, 10, 02, 15, 00), end_date = new DateTime(2017, 09, 10, 02, 20, 00), color = "#76B007", room_id = 5 }, 
                new ColoredEvent{ id = 10, text = "New event", start_date = new DateTime(2017, 09, 10, 03, 35, 00), end_date = new DateTime(2017, 09, 10, 03, 40, 00), color = "#FE7510", room_id = 4 }, 
                new ColoredEvent{ id = 11, text = "New event", start_date = new DateTime(2017, 09, 08, 06, 15, 00), end_date = new DateTime(2017, 09, 08, 06, 20, 00), color = "false", room_id = null }, 
                new ColoredEvent{ id = 12, text = "New event", start_date = new DateTime(2017, 09, 10, 00, 45, 00), end_date = new DateTime(2017, 09, 10, 00, 50, 00), color = "#FE7510", room_id = null }, 
                new ColoredEvent{ id = 13, text = "new111", start_date = new DateTime(2017, 09, 05, 04, 30, 00), end_date = new DateTime(2017, 09, 05, 04, 35, 00), color = "#FE7510", room_id = null }, 
                new ColoredEvent{ id = 14, text = "New event", start_date = new DateTime(2017, 09, 10, 05, 10, 00), end_date = new DateTime(2017, 09, 10, 05, 15, 00), color = "#76B007", room_id = null }, 
                new ColoredEvent{ id = 15, text = "New event", start_date = new DateTime(2017, 09, 14, 17, 05, 00), end_date = new DateTime(2017, 09, 14, 17, 10, 00), color = null, room_id = null }, 
                new ColoredEvent{ id = 16, text = "New event", start_date = new DateTime(2017, 09, 14, 04, 30, 00), end_date = new DateTime(2017, 09, 14, 04, 35, 00), color = "null", room_id = null }, 
                new ColoredEvent{ id = 17, text = "New event", start_date = new DateTime(2017, 09, 14, 09, 05, 00), end_date = new DateTime(2017, 09, 14, 09, 10, 00), color = "#FE7510", room_id = 4 }, 
                new ColoredEvent{ id = 18, text = "New event", start_date = new DateTime(2017, 09, 17, 07, 00, 00), end_date = new DateTime(2017, 09, 17, 08, 00, 00), color = "#FE7510", room_id = 4 }, 
                new ColoredEvent{ id = 19, text = "New event", start_date = new DateTime(2017, 09, 17, 06, 00, 00), end_date = new DateTime(2017, 09, 17, 07, 00, 00), color = "#76B007", room_id = 5 }, 
                new ColoredEvent{ id = 20, text = "New event", start_date = new DateTime(2017, 09, 17, 08, 00, 00), end_date = new DateTime(2017, 09, 17, 09, 00, 00), color = "#FE7510", room_id = 5 }, 
                new ColoredEvent{ id = 21, text = "New event", start_date = new DateTime(2017, 09, 17, 08, 00, 00), end_date = new DateTime(2017, 09, 17, 09, 00, 00), color = "#ccc", room_id = 3 }, 
                new ColoredEvent{ id = 22, text = "New event", start_date = new DateTime(2017, 09, 17, 22, 00, 00), end_date = new DateTime(2017, 09, 17, 23, 00, 00), color = "#ccc", room_id = 6 }, 
                new ColoredEvent{ id = 23, text = "New event", start_date = new DateTime(2017, 09, 17, 21, 00, 00), end_date = new DateTime(2017, 09, 17, 22, 00, 00), color = "#ccc", room_id = 3 }, 
                new ColoredEvent{ id = 24, text = "New event", start_date = new DateTime(2017, 09, 17, 16, 25, 00), end_date = new DateTime(2017, 09, 17, 16, 30, 00), color = "#ccc", room_id = 6 }, 
                new ColoredEvent{ id = 25, text = "New event", start_date = new DateTime(2017, 09, 17, 21, 00, 00), end_date = new DateTime(2017, 09, 17, 22, 00, 00), color = "#ccc", room_id = 5 }, 
                new ColoredEvent{ id = 26, text = "New event", start_date = new DateTime(2017, 09, 17, 11, 00, 00), end_date = new DateTime(2017, 09, 17, 12, 00, 00), color = "#ccc", room_id = 4 }, 
                new ColoredEvent{ id = 27, text = "New event", start_date = new DateTime(2017, 09, 17, 03, 00, 00), end_date = new DateTime(2017, 09, 17, 04, 00, 00), color = "#76B007", room_id = 4 }, 
                new ColoredEvent{ id = 28, text = "New event", start_date = new DateTime(2017, 09, 17, 11, 15, 00), end_date = new DateTime(2017, 09, 17, 11, 20, 00), color = "#FE7510", room_id = 6 }, 
                new ColoredEvent{ id = 29, text = "New event", start_date = new DateTime(2017, 09, 17, 00, 30, 00), end_date = new DateTime(2017, 09, 17, 00, 35, 00), color = "#ccc", room_id = 6 }, 
                new ColoredEvent{ id = 30, text = "New event", start_date = new DateTime(2017, 09, 16, 02, 20, 00), end_date = new DateTime(2017, 09, 16, 02, 25, 00), color = "#ccc", room_id = 4 }, 
                new ColoredEvent{ id = 31, text = "New event for text", start_date = new DateTime(2017, 09, 07, 10, 00, 00), end_date = new DateTime(2017, 09, 07, 15, 30, 00), color = "#FE7510", room_id = 6 }, 
                new ColoredEvent{ id = 32, text = "New changed event", start_date = new DateTime(2017, 09, 08, 10, 45, 00), end_date = new DateTime(2017, 09, 08, 11, 15, 00), color = "#ccc", room_id = 3 }, 
                new ColoredEvent{ id = 33, text = "New event", start_date = new DateTime(2017, 09, 05, 04, 00, 00), end_date = new DateTime(2017, 09, 05, 05, 00, 00), color = "#ccc", room_id = 4 }, 
                new ColoredEvent{ id = 34, text = "New event", start_date = new DateTime(2017, 09, 07, 04, 30, 00), end_date = new DateTime(2017, 09, 07, 04, 35, 00), color = null, room_id = null }, 
                new ColoredEvent{ id = 35, text = "New event 28/08", start_date = new DateTime(2017, 09, 07, 07, 35, 00), end_date = new DateTime(2017, 09, 07, 07, 40, 00), color = "false", room_id = null }, 
                new ColoredEvent{ id = 37, text = "New event", start_date = new DateTime(2017, 09, 09, 12, 45, 00), end_date = new DateTime(2017, 09, 09, 12, 50, 00), color = "#FE7510", room_id = 3 }, 
                new ColoredEvent{ id = 38, text = "New event", start_date = new DateTime(2017, 09, 06, 05, 10, 00), end_date = new DateTime(2017, 09, 06, 05, 15, 00), color = "#ccc", room_id = 3 }, 
                new ColoredEvent{ id = 40, text = "New event", start_date = new DateTime(2017, 09, 06, 14, 30, 00), end_date = new DateTime(2017, 09, 06, 18, 30, 00), color = "#ccc", room_id = null }
            });

            context.Events.AddRange(new List<Event>{ 
                new Event{ id = 7, text = "Scrum meeting - updated-", start_date = new DateTime(2013, 08, 05, 08, 20, 00), end_date = new DateTime(2013, 08, 05, 11, 00, 00), room_id = 3, user_id = null }, 
                new Event{ id = 8, text = "Product release", start_date = new DateTime(2012, 09, 11, 12, 45, 00), end_date = new DateTime(2012, 09, 11, 15, 40, 00), room_id = 3, user_id = null }, 
                new Event{ id = 9, text = "Review release plans", start_date = new DateTime(2013, 08, 02, 09, 20, 00), end_date = new DateTime(2013, 08, 02, 11, 50, 00), room_id = 4, user_id = null }, 
                new Event{ id = 10, text = "New project presentation", start_date = new DateTime(2017, 09, 10, 12, 40, 00), end_date = new DateTime(2017, 09, 10, 14, 40, 00), room_id = 5, user_id = null }, 
                new Event{ id = 13, text = "Sprint review", start_date = new DateTime(2017, 09, 02, 08, 10, 00), end_date = new DateTime(2017, 09, 02, 08, 15, 00), room_id = 5, user_id = null }, 
                new Event{ id = 14, text = "Sprint review", start_date = new DateTime(2012, 09, 04, 16, 35, 00), end_date = new DateTime(2012, 09, 04, 18, 00, 00), room_id = 6, user_id = null }, 
                new Event{ id = 15, text = "Web security seminar ", start_date = new DateTime(2017, 08, 11, 14, 00, 00), end_date = new DateTime(2017, 08, 15, 16, 00, 00), room_id = 4, user_id = null }, 
                new Event{ id = 16, text = "C# 4.0 Features seminar", start_date = new DateTime(2013, 08, 06, 08, 30, 00), end_date = new DateTime(2013, 08, 06, 12, 00, 00), room_id = 5, user_id = null }, 
                new Event{ id = 33, text = "New event", start_date = new DateTime(2017, 08, 16, 06, 50, 00), end_date = new DateTime(2017, 08, 16, 06, 55, 00), room_id = null, user_id = null }, 
                new Event{ id = 48, text = "room4", start_date = new DateTime(2017, 09, 07, 08, 55, 00), end_date = new DateTime(2017, 09, 07, 13, 30, 00), room_id = 6, user_id = null }, 
                new Event{ id = 51, text = "New room28", start_date = new DateTime(2017, 09, 07, 02, 30, 00), end_date = new DateTime(2017, 09, 07, 06, 35, 00), room_id = 4, user_id = null }, 
                new Event{ id = 54, text = "New room3", start_date = new DateTime(2017, 09, 07, 07, 55, 00), end_date = new DateTime(2017, 09, 07, 15, 05, 00), room_id = 5, user_id = null }, 
                new Event{ id = 56, text = "room1", start_date = new DateTime(2017, 09, 07, 07, 30, 00), end_date = new DateTime(2017, 09, 07, 09, 45, 00), room_id = 3, user_id = null }, 
                new Event{ id = 63, text = "New event", start_date = new DateTime(2017, 09, 12, 00, 00, 00), end_date = new DateTime(2017, 09, 12, 00, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 64, text = "Press release", start_date = new DateTime(2017, 09, 06, 03, 55, 00), end_date = new DateTime(2017, 09, 06, 04, 00, 00), room_id = null, user_id = null }, 
                new Event{ id = 68, text = "Conference557", start_date = new DateTime(2017, 09, 09, 04, 50, 00), end_date = new DateTime(2017, 09, 09, 04, 55, 00), room_id = null, user_id = null }, 
                new Event{ id = 69, text = "Conference77", start_date = new DateTime(2017, 09, 09, 11, 00, 00), end_date = new DateTime(2017, 09, 09, 11, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 70, text = "New event", start_date = new DateTime(2017, 09, 17, 03, 10, 00), end_date = new DateTime(2017, 09, 17, 03, 15, 00), room_id = null, user_id = null }, 
                new Event{ id = 71, text = "New event", start_date = new DateTime(2017, 09, 08, 00, 00, 00), end_date = new DateTime(2017, 09, 08, 00, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 103, text = "Release deadline", start_date = new DateTime(2017, 09, 20, 11, 00, 00), end_date = new DateTime(2017, 09, 20, 13, 30, 00), room_id = null, user_id = null }, 
                new Event{ id = 106, text = "New event", start_date = new DateTime(2017, 09, 14, 08, 55, 00), end_date = new DateTime(2017, 09, 14, 09, 00, 00), room_id = null, user_id = null }, 
                new Event{ id = 107, text = "New event", start_date = new DateTime(2017, 09, 22, 07, 45, 00), end_date = new DateTime(2017, 09, 22, 10, 40, 00), room_id = null, user_id = null }, 
                new Event{ id = 108, text = "New event", start_date = new DateTime(2017, 09, 13, 04, 00, 00), end_date = new DateTime(2017, 09, 13, 04, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 109, text = "New event", start_date = new DateTime(2017, 09, 13, 04, 50, 00), end_date = new DateTime(2017, 09, 13, 04, 55, 00), room_id = null, user_id = null }, 
                new Event{ id = 110, text = "New event", start_date = new DateTime(2017, 09, 14, 05, 25, 00), end_date = new DateTime(2017, 09, 14, 05, 30, 00), room_id = null, user_id = null }, 
                new Event{ id = 111, text = "New event", start_date = new DateTime(2017, 09, 12, 10, 20, 00), end_date = new DateTime(2017, 09, 12, 10, 25, 00), room_id = null, user_id = null }, 
                new Event{ id = 112, text = "New event", start_date = new DateTime(2017, 09, 13, 08, 15, 00), end_date = new DateTime(2017, 09, 13, 08, 20, 00), room_id = null, user_id = null }, 
                new Event{ id = 113, text = "New event", start_date = new DateTime(2017, 09, 16, 00, 00, 00), end_date = new DateTime(2017, 09, 20, 00, 00, 00), room_id = null, user_id = null }, 
                new Event{ id = 114, text = "New event", start_date = new DateTime(2017, 09, 17, 09, 45, 00), end_date = new DateTime(2017, 09, 17, 13, 20, 00), room_id = 4, user_id = null }, 
                new Event{ id = 115, text = "New event33", start_date = new DateTime(2017, 08, 30, 00, 00, 00), end_date = new DateTime(2017, 09, 03, 00, 00, 00), room_id = 3, user_id = null }, 
                new Event{ id = 116, text = "New event", start_date = new DateTime(2012, 02, 15, 03, 35, 00), end_date = new DateTime(2012, 02, 15, 07, 40, 00), room_id = null, user_id = null }, 
                new Event{ id = 119, text = "New event", start_date = new DateTime(2012, 08, 04, 06, 50, 00), end_date = new DateTime(2012, 08, 04, 06, 55, 00), room_id = null, user_id = null }, 
                new Event{ id = 120, text = "New eve room1", start_date = new DateTime(2017, 09, 07, 10, 20, 00), end_date = new DateTime(2017, 09, 07, 15, 50, 00), room_id = 3, user_id = null }, 
                new Event{ id = 121, text = "New room28", start_date = new DateTime(2017, 09, 07, 06, 30, 00), end_date = new DateTime(2017, 09, 07, 12, 50, 00), room_id = 4, user_id = null }, 
                new Event{ id = 122, text = "New room3", start_date = new DateTime(2017, 09, 07, 00, 00, 00), end_date = new DateTime(2017, 09, 14, 00, 00, 00), room_id = 5, user_id = null }, 
                new Event{ id = 123, text = "room1", start_date = new DateTime(2017, 09, 07, 02, 00, 00), end_date = new DateTime(2017, 09, 07, 05, 50, 00), room_id = 3, user_id = null }, 
                new Event{ id = 124, text = "New event", start_date = new DateTime(2017, 09, 12, 00, 00, 00), end_date = new DateTime(2017, 09, 12, 00, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 125, text = "Press release", start_date = new DateTime(2017, 09, 06, 03, 55, 00), end_date = new DateTime(2017, 09, 06, 04, 00, 00), room_id = null, user_id = null }, 
                new Event{ id = 126, text = "Conference557", start_date = new DateTime(2017, 09, 09, 04, 50, 00), end_date = new DateTime(2017, 09, 09, 04, 55, 00), room_id = null, user_id = null }, 
                new Event{ id = 127, text = "Conference77", start_date = new DateTime(2017, 09, 09, 08, 10, 00), end_date = new DateTime(2017, 09, 09, 08, 15, 00), room_id = null, user_id = null }, 
                new Event{ id = 128, text = "New event", start_date = new DateTime(2012, 09, 05, 03, 10, 00), end_date = new DateTime(2012, 09, 05, 03, 15, 00), room_id = null, user_id = null }, 
                new Event{ id = 129, text = "Team meating", start_date = new DateTime(2012, 09, 08, 11, 05, 00), end_date = new DateTime(2012, 09, 08, 13, 45, 00), room_id = null, user_id = null }, 
                new Event{ id = 130, text = "New event", start_date = new DateTime(2017, 09, 08, 00, 00, 00), end_date = new DateTime(2017, 09, 08, 00, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 131, text = "New event", start_date = new DateTime(2012, 09, 02, 08, 55, 00), end_date = new DateTime(2012, 09, 02, 09, 00, 00), room_id = null, user_id = null }, 
                new Event{ id = 132, text = "New event", start_date = new DateTime(2012, 09, 10, 15, 25, 00), end_date = new DateTime(2012, 09, 10, 18, 20, 00), room_id = null, user_id = null }, 
                new Event{ id = 133, text = "New event", start_date = new DateTime(2012, 09, 01, 04, 00, 00), end_date = new DateTime(2012, 09, 01, 04, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 134, text = "New event", start_date = new DateTime(2012, 09, 01, 04, 50, 00), end_date = new DateTime(2012, 09, 01, 04, 55, 00), room_id = null, user_id = null }, 
                new Event{ id = 135, text = "New event", start_date = new DateTime(2012, 09, 02, 05, 25, 00), end_date = new DateTime(2012, 09, 02, 05, 30, 00), room_id = null, user_id = null }, 
                new Event{ id = 136, text = "New event", start_date = new DateTime(2017, 09, 12, 10, 20, 00), end_date = new DateTime(2017, 09, 12, 10, 25, 00), room_id = null, user_id = null }, 
                new Event{ id = 137, text = "New event", start_date = new DateTime(2012, 09, 01, 08, 15, 00), end_date = new DateTime(2012, 09, 01, 08, 20, 00), room_id = null, user_id = null }, 
                new Event{ id = 138, text = "New event", start_date = new DateTime(2012, 09, 02, 02, 35, 00), end_date = new DateTime(2012, 09, 02, 02, 40, 00), room_id = null, user_id = null }, 
                new Event{ id = 139, text = "New event", start_date = new DateTime(2012, 09, 05, 09, 45, 00), end_date = new DateTime(2012, 09, 05, 13, 20, 00), room_id = 4, user_id = null }, 
                new Event{ id = 140, text = "New event33", start_date = new DateTime(2013, 08, 06, 04, 50, 00), end_date = new DateTime(2013, 08, 06, 04, 55, 00), room_id = 3, user_id = null }, 
                new Event{ id = 141, text = "New event", start_date = new DateTime(2013, 02, 03, 03, 35, 00), end_date = new DateTime(2013, 02, 03, 07, 40, 00), room_id = null, user_id = null }, 
                new Event{ id = 142, text = "Testing", start_date = new DateTime(2012, 09, 07, 01, 20, 00), end_date = new DateTime(2012, 09, 10, 01, 40, 00), room_id = null, user_id = null }, 
                new Event{ id = 143, text = "New event", start_date = new DateTime(2017, 12, 27, 05, 50, 00), end_date = new DateTime(2017, 12, 27, 09, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 144, text = "New event", start_date = new DateTime(2017, 12, 28, 01, 15, 00), end_date = new DateTime(2017, 12, 28, 04, 45, 00), room_id = null, user_id = null }, 
                new Event{ id = 147, text = "New event", start_date = new DateTime(2017, 09, 05, 03, 00, 00), end_date = new DateTime(2017, 09, 05, 07, 20, 00), room_id = null, user_id = null }, 
                new Event{ id = 150, text = "available credentials are test/test and user/user", start_date = new DateTime(2017, 09, 26, 00, 05, 00), end_date = new DateTime(2017, 09, 26, 05, 05, 00), room_id = 6, user_id = null }, 
                new Event{ id = 153, text = "New event", start_date = new DateTime(2017, 09, 20, 02, 45, 00), end_date = new DateTime(2017, 09, 20, 05, 55, 00), room_id = null, user_id = null }, 
                new Event{ id = 154, text = "meeting", start_date = new DateTime(2017, 09, 08, 02, 30, 00), end_date = new DateTime(2017, 09, 08, 06, 35, 00), room_id = null, user_id = null }, 
                new Event{ id = 156, text = "New event", start_date = new DateTime(2012, 08, 16, 01, 35, 00), end_date = new DateTime(2012, 08, 16, 05, 10, 00), room_id = null, user_id = null }, 
                new Event{ id = 157, text = "New event", start_date = new DateTime(2017, 09, 09, 01, 35, 00), end_date = new DateTime(2017, 09, 09, 03, 30, 00), room_id = null, user_id = null }, 
                new Event{ id = 159, text = "New event", start_date = new DateTime(2012, 08, 21, 04, 35, 00), end_date = new DateTime(2012, 08, 21, 09, 45, 00), room_id = null, user_id = null }, 
                new Event{ id = 160, text = "New event", start_date = new DateTime(2012, 08, 22, 03, 35, 00), end_date = new DateTime(2012, 08, 22, 06, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 161, text = "New event", start_date = new DateTime(2012, 08, 20, 02, 15, 00), end_date = new DateTime(2012, 08, 20, 04, 00, 00), room_id = null, user_id = null }, 
                new Event{ id = 163, text = "New event", start_date = new DateTime(2017, 09, 23, 08, 00, 00), end_date = new DateTime(2017, 09, 23, 18, 30, 00), room_id = 4, user_id = null }, 
                new Event{ id = 167, text = "meeting", start_date = new DateTime(2017, 09, 19, 15, 00, 00), end_date = new DateTime(2017, 09, 19, 21, 30, 00), room_id = 5, user_id = null }, 
                new Event{ id = 170, text = "New event", start_date = new DateTime(2017, 09, 19, 01, 30, 00), end_date = new DateTime(2017, 09, 19, 05, 30, 00), room_id = 6, user_id = null }, 
                new Event{ id = 172, text = "New event", start_date = new DateTime(2012, 08, 23, 07, 30, 00), end_date = new DateTime(2012, 08, 23, 09, 30, 00), room_id = null, user_id = null }, 
                new Event{ id = 173, text = "Only ''test'' can edit this event", start_date = new DateTime(2017, 09, 29, 03, 35, 00), end_date = new DateTime(2017, 09, 29, 08, 20, 00), room_id = 3, user_id = 2 }, 
                new Event{ id = 174, text = "Only ''user'' can edit this event", start_date = new DateTime(2017, 09, 27, 01, 05, 00), end_date = new DateTime(2017, 09, 27, 06, 05, 00), room_id = 3, user_id = 1 }, 
                new Event{ id = 175, text = "New event", start_date = new DateTime(2017, 09, 20, 04, 10, 00), end_date = new DateTime(2017, 09, 20, 05, 25, 00), room_id = null, user_id = null }, 
                new Event{ id = 177, text = "SvetaHello", start_date = new DateTime(2014, 08, 26, 02, 40, 00), end_date = new DateTime(2014, 08, 26, 02, 45, 00), room_id = 3, user_id = 3 }, 
                new Event{ id = 178, text = "New event for Sveta", start_date = new DateTime(2017, 09, 28, 10, 20, 00), end_date = new DateTime(2017, 09, 28, 10, 25, 00), room_id = 3, user_id = 1 }, 
                new Event{ id = 179, text = "tnt club", start_date = new DateTime(2014, 08, 12, 00, 00, 00), end_date = new DateTime(2014, 08, 12, 00, 05, 00), room_id = null, user_id = null }, 
                new Event{ id = 180, text = "meet up", start_date = new DateTime(2017, 09, 20, 02, 00, 00), end_date = new DateTime(2017, 09, 20, 03, 20, 00), room_id = null, user_id = null }, 
                new Event{ id = 181, text = "new event 20/08", start_date = new DateTime(2017, 09, 20, 08, 05, 00), end_date = new DateTime(2017, 09, 20, 08, 10, 00), room_id = null, user_id = null }, 
                new Event{ id = 182, text = "tnt club", start_date = new DateTime(2017, 10, 01, 04, 35, 00), end_date = new DateTime(2017, 10, 01, 04, 40, 00), room_id = 3, user_id = 1 }, 
                new Event{ id = 184, text = "New event", start_date = new DateTime(2017, 09, 19, 08, 35, 00), end_date = new DateTime(2017, 09, 19, 08, 40, 00), room_id = null, user_id = null }, 
                new Event{ id = 185, text = "custom event boxes", start_date = new DateTime(2014, 08, 27, 06, 10, 00), end_date = new DateTime(2014, 08, 27, 06, 15, 00), room_id = null, user_id = null }, 
                new Event{ id = 186, text = "meeting", start_date = new DateTime(2017, 09, 21, 13, 30, 00), end_date = new DateTime(2017, 09, 21, 14, 00, 00), room_id = 3, user_id = null }, 
                new Event{ id = 187, text = "New event", start_date = new DateTime(2014, 08, 28, 11, 00, 00), end_date = new DateTime(2014, 08, 28, 11, 05, 00), room_id = 1, user_id = 1 }, 
                new Event{ id = 188, text = "!!!", start_date = new DateTime(2017, 09, 07, 04, 10, 00), end_date = new DateTime(2017, 09, 07, 04, 15, 00), room_id = null, user_id = null }
            });

            context.Grids.AddRange(new List<Grid>{ 
                new Grid{ id = 2, text = "Koengen", details = "Bergen, start_date = Norway", end_date = new DateTime(2012, 08, 02, 18, 00, 00) }, 
                new Grid{ id = 3, text = "Folkets Park", details = "Malmo, start_date = SE", end_date = new DateTime(2012, 08, 03, 11, 00, 00) }, 
                new Grid{ id = 4, text = "Estadio Jose Zorila", details = "Valladolid, start_date = Spain", end_date = new DateTime(2012, 08, 08, 18, 00, 00) }, 
                new Grid{ id = 5, text = "Bessa Stadium", details = "Porto, start_date = Portugal", end_date = new DateTime(2012, 08, 11, 10, 00, 00) }, 
                new Grid{ id = 6, text = "Estadio Olimpico - Seville", details = "Seville, start_date = Spain", end_date = new DateTime(2012, 08, 12, 14, 00, 00) }, 
                new Grid{ id = 7, text = "Indianapolis Tennis Championships", details = "Indianapolis Tennis Center Indianapolis, start_date = IN", end_date = new DateTime(2012, 08, 18, 18, 00, 00) }, 
                new Grid{ id = 8, text = "Molson Amphitheatre", details = "Toronto, start_date = ON", end_date = new DateTime(2012, 08, 24, 16, 00, 00) }, 
                new Grid{ id = 9, text = "Bell Centre", details = "Montreal, start_date = QC", end_date = new DateTime(2012, 08, 25, 18, 00, 00) }, 
                new Grid{ id = 10, text = "Countrywide Classic Tennis", details = "Los Angeles Tennis Center. Los Angeles, start_date = CA", end_date = new DateTime(2012, 08, 27, 14, 00, 00) }, 
                new Grid{ id = 11, text = "Sea dance", details = "Budva", start_date = new DateTime(2017, 09, 06, 00, 00, 00), end_date = new DateTime(2017, 09, 06, 00, 05, 00) }, 
                new Grid{ id = 12, text = "New event", details = "", start_date = new DateTime(2017, 09, 20, 02, 20, 00), end_date = new DateTime(2017, 09, 20, 07, 15, 00) }, 
                new Grid{ id = 13, text = "New event", details = "", start_date = new DateTime(2017, 09, 19, 01, 30, 00), end_date = new DateTime(2017, 09, 19, 08, 10, 00) }, 
                new Grid{ id = 14, text = "queen", details = "", start_date = new DateTime(2014, 08, 28, 00, 00, 00), end_date = new DateTime(2014, 08, 28, 00, 05, 00) }
            });

            context.Recurrings.AddRange(new List<Recurring>{ 
                new Recurring{ id = 14, text = "New event", start_date = new DateTime(2017, 09, 26, 04, 55, 00), end_date = new DateTime(2017, 09, 26, 07, 25, 00), room_id = null, event_length = null, rec_type = null, event_pid = null }, 
                new Recurring{ id = 15, text = "New event1", start_date = new DateTime(2017, 09, 26, 02, 00, 00), end_date = new DateTime(9999, 02, 01, 00, 00, 00), room_id = null, event_length = 4800, rec_type = "week_1___1,2,3#no", event_pid = null }, 
                new Recurring{ id = 23, text = "Every workday", start_date = new DateTime(2017, 09, 26, 01, 25, 00), end_date = new DateTime(2017, 10, 10, 01, 25, 00), room_id = null, event_length = 11400, rec_type = "week_1___1,2,3,4,5#10", event_pid = null }, 
                new Recurring{ id = 25, text = "meeting", start_date = new DateTime(2017, 09, 29, 17, 20, 00), end_date = new DateTime(2017, 09, 29, 17, 25, 00), room_id = null, event_length = null, rec_type = "", event_pid = null }
            });

            context.Rooms.AddRange(new List<Room>{ 
                new Room{ key = 3, label = "Room #1" }, 
                new Room{ key = 4, label = "Room #2" }, 
                new Room{ key = 5, label = "Room #3" }, 
                new Room{ key = 6, label = "Room #4" }
            });

            context.ValidEvents.AddRange(new List<ValidEvent>{
                new ValidEvent { id = 1, text = "rrr33", start_date = new DateTime(2017, 09, 07, 05, 20, 00), end_date = new DateTime(2017, 09, 07, 10, 00, 00), email = "dddd@mail.com" },
                new ValidEvent { id = 2, text = "New event", start_date = new DateTime(2017, 09, 08, 09, 00, 00), end_date = new DateTime(2017, 09, 08, 13, 25, 00), email = "4" },
                new ValidEvent { id = 3, text = "New event tyu", start_date = new DateTime(2017, 09, 06, 07, 40, 00), end_date = new DateTime(2017, 09, 06, 12, 40, 00), email = "" }
            });

            context.SaveChanges();
        }
    }
}
