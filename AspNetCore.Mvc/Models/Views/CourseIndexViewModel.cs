using AspNetCore.Mvc.Models.Components;
using AspNetCore.Mvc.Models.Courses;

namespace AspNetCore.Mvc.Models.Views;

public class CourseIndexViewModel
{
    public CourseSectionViewModel Courses { get; set; } = new CourseSectionViewModel()
    {
        Id = "course-section",
        Nav =  new NavMenuViewModel() 
        {
            IndexImg = new LinkViewModel() { ControllerName = "Home", ActionName = "Index", Text = "" },
            HouseIcon = new ImageViewModel() { ImageUrl = "../icons/home-icon.svg", AltText = "house icon" },
            HomeLink = new LinkViewModel() { ControllerName = "Home", ActionName = "Index", Text = "" },
            Vector = new ImageViewModel() { ImageUrl = "../icons/Vector.svg", AltText = "vector icon" },
            CoursesLink = new LinkViewModel() { ControllerName = "Course", ActionName = "Index", Text = "Courses" }

        },
        CourseSearch = new CourseSearchViewModel()
        {
            Title = "Courses",
            ButtonText = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "All Categories" },
            Items = new List<LinkViewModel>()
            {
                new LinkViewModel() { ControllerName = "", ActionName = "", Text = "Html"},
                new LinkViewModel() { ControllerName = "", ActionName = "", Text = "Css"},
                new LinkViewModel() { ControllerName = "", ActionName = "", Text = "C#"},
            },
            Placeholder = "Search courses",
        },
        CourseCard = 
        [
            new CourseCardViewModel
            {
                CardImg = new ImageViewModel() { ImageUrl = "../icons/best-seller.svg", AltText = "best seller"},
                Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = ""},
                ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_1.svg", AltText = "hands on a laptop"},
                CardHeader = "Fullstack Web Developer Course from Scratch",
                Author = "By Robert Fox",
                PriceText = "$12.50",
                PriceSale = "",
                ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock"},
                HoursText = "220 hours",
                ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb"},
                RatingText = "94 % (4.2k)"

            },
             new CourseCardViewModel
             {
                 CardImg = new ImageViewModel() { ImageUrl = "", AltText = "" },
                 Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                 ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_2.svg", AltText = "man looking at a laptop" },
                 CardHeader = "HTML, CSS, JavaScript Web Developer",
                 Author = "By Jenny Wilson & Marvin McKinney",
                 PriceText = "$15.99",
                 PriceSale = "",
                 ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                 HoursText = "160 hours",
                 ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                 RatingText = "92 % (3.1k)"

             },
              new CourseCardViewModel
              {
                  CardImg = new ImageViewModel() { ImageUrl = "", AltText = "" },
                  Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                  ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_3.svg", AltText = "happy women" },
                  CardHeader = "The Complete Front-End Web Development Course",
                  Author = "By Albert Flores",
                  PriceText = "$49.99",
                  PriceSale = "$9.99",
                  ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                  HoursText = "100 hours",
                  ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                  RatingText = "98 % (2.7k)"

              },
               new CourseCardViewModel
               {
                   CardImg = new ImageViewModel() { ImageUrl = "", AltText = "" },
                   Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                   ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_4.svg", AltText = "smiling woman" },
                   CardHeader = "iOS & Swift - The Complete iOS App Development Course",
                   Author = "By Marvin McKinney",
                   PriceText = "$15.99",
                   PriceSale = "",
                   ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                   HoursText = "160 hourss",
                   ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                   RatingText = "92 % (3.1k)"

               },
                new CourseCardViewModel
                {
                    CardImg = new ImageViewModel() { ImageUrl = "../icons/best-seller.svg", AltText = "best seller" },
                    Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                    ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_5.svg", AltText = "woman in dark hair waves at a laptop" },
                    CardHeader = "Data Science & Machine Learning with Python",
                    Author = "By Esther Howard",
                    PriceText = "$11.20",
                    PriceSale = "",
                    ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                    HoursText = "160 hours",
                    ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                    RatingText = "92 % (3.1k)"

                },
                 new CourseCardViewModel
                 {
                     CardImg = new ImageViewModel() { ImageUrl = "", AltText = "" },
                     Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                     ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_6.svg", AltText = "woman in dark hair reading from a paper" },
                     CardHeader = "Creative CSS Drawing Course: Make Art With CSS",
                     Author = "By Robert Fox",
                     PriceText = "$10.50",
                     PriceSale = "",
                     ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                     HoursText = "220 hours",
                     ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                     RatingText = "94 % (4.2k)"

                 },
                  new CourseCardViewModel
                  {
                      CardImg = new ImageViewModel() { ImageUrl = "", AltText = "" },
                      Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                      ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_7.svg", AltText = "smiling woman with a laptop" },
                      CardHeader = "Blender Character Creator v2.0 for Video Games Design",
                      Author = "By Ralph Edwards",
                      PriceText = "$18.99",
                      PriceSale = "",
                      ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                      HoursText = "160 hours",
                      ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                      RatingText = "92 % (3.1k)"

                  },
                   new CourseCardViewModel
                   {
                       CardImg = new ImageViewModel() { ImageUrl = "", AltText = "" },
                       Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                       ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_8.svg", AltText = "smiling man showing his hands" },
                       CardHeader = "The Ultimate Guide to 2D Mobile Game Development with Unity",
                       Author = "By Albert Flores",
                       PriceText = "$49.99",
                       PriceSale = "$12.99",
                       ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                       HoursText = "100 hours",
                       ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                       RatingText = "98 % (2.7k)"

                   },
                    new CourseCardViewModel
                    {
                        CardImg = new ImageViewModel() { ImageUrl = "", AltText = "" },
                        Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "" },
                        ImageIcon = new ImageViewModel() { ImageUrl = "../test/images/course_9.svg", AltText = "man typing on a laptop" },
                        CardHeader = "Learn JMETER from Scratch on Live Apps-Performance Testing",
                        Author = "By Jenny Wilson",
                        PriceText = "$14.50",
                        PriceSale = "",
                        ClockIcon = new ImageViewModel() { ImageUrl = "../icons/clock.svg", AltText = "clock" },
                        HoursText = "160 hours",
                        ThumbIcon = new ImageViewModel() { ImageUrl = "../icons/thumb-like.svg", AltText = "thumb" },
                        RatingText = "92 % (3.1k)",

                    },
        ], 
        PageLinks = 
        [
            new LinkViewModel() {ControllerName = "", ActionName = "", Text = "1" },
            new LinkViewModel() {ControllerName = "", ActionName = "", Text = "2" },
            new LinkViewModel() {ControllerName = "", ActionName = "", Text = "3" },

        ],
        LeftArrow = new ImageViewModel() { ImageUrl = "../icons/Property-arrow 1=left.svg", AltText = "left arrow" },
        RightArrow = new ImageViewModel() { ImageUrl = "../icons/Property-arrow 1=right.svg", AltText = "right arrow" }

        
    };

}
