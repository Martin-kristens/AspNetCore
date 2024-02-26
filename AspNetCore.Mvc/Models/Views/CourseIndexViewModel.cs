using AspNetCore.Mvc.Models.Courses.Components;
using AspNetCore.Mvc.ViewModels.Components;
using AspNetCore.Mvc.ViewModels.Courses;

namespace AspNetCore.Mvc.Models.Views;

public class CourseIndexViewModel
{
    //om man vill använda denna är den klar
    public ProfileHeaderViewModel ProfileHeader { get; set; } = new ProfileHeaderViewModel() 
    {
        Id = "profile-header",
        LogoLink = new LinkViewModel() { ControllerName = "Home", ActionName = "Index", Text = "" },
        Logo = new ImageViewModel() { ImageUrl = "/images/solid.svg", AltText = "Logo" },
        Links =
            [
                new LinkViewModel() { ControllerName = "", ActionName = "", Text = "Overview"},
                new LinkViewModel() { ControllerName = "", ActionName = "", Text = "Courses"},
                new LinkViewModel() { ControllerName = "", ActionName = "", Text = "Contact"},
            ],
        LightText = "Light",
        DarkText = "Dark",
        Profile = new ImageViewModel() { ImageUrl = "/images/account-profile.svg", AltText = "profile picture of a smilling man with glasses" },
    };
    public CourseSectionViewModel Courses { get; set; } = new CourseSectionViewModel()
    {
        Id = "course-section",
     
        Nav =  new NavMenuViewModel() 
        {
            IndexImg = new LinkViewModel() { ControllerName = "Home", ActionName = "Index", Text = "" },
            HouseIcon = new ImageViewModel() { ImageUrl = "../icons/home-icon.svg", AltText = "house icon" },
            HomeLink = new LinkViewModel() { ControllerName = "Home", ActionName = "Index", Text = "Home" },
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
                CardImg = new ImageViewModel() { ImageUrl = "/icons/best-seller.svg", AltText = "best seller"},
                Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = ""},
                ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_1.svg", AltText = "hands on a laptop"},
                CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                 ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_2.svg", AltText = "man looking at a laptop" },
                 CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                  ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_3.svg", AltText = "happy women" },
                  CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                   ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_4.svg", AltText = "smiling woman" },
                   CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                    ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_5.svg", AltText = "woman in dark hair waves at a laptop" },
                    CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                     ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_6.svg", AltText = "woman in dark hair reading from a paper" },
                     CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                      ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_7.svg", AltText = "smiling woman with a laptop" },
                      CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                       ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_8.svg", AltText = "smiling man showing his hands" },
                       CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
                        ImageIcon = new ImageViewModel() { ImageUrl = "/images/course_9.svg", AltText = "man typing on a laptop" },
                        CircleIcon = new ImageViewModel() { ImageUrl = "/icons/course-picture-icon.svg", AltText = "circle icon in picture"},
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
            new LinkViewModel() {ControllerName = "", ActionName = "", Text = "4" },

        ],
        LeftArrow = new ImageViewModel() { ImageUrl = "../icons/Property-arrow 1=left.svg", AltText = "left arrow" },
        RightArrow = new ImageViewModel() { ImageUrl = "../icons/Property-arrow 1=right.svg", AltText = "right arrow" }

        
    };

    public WorkWithUsViewModel WorkWithUsSection { get; set; } = new WorkWithUsViewModel()
    {
        Id = "work-with-us",
        Text = "Ready to get started?",
        Header = new HeadingViewModel() 
            {
                Header1 = "Take Your",
                SpanText = "Skills",
                Header2 = "to the Next Level",
            },
        Link = new LinkViewModel() { ControllerName = "", ActionName = "", Text = "Work with us" },
        WorkImg = new ImageViewModel() { ImageUrl = "/images/work-with-us-illustration.svg" , AltText = "cartoon sitting by a desk" },
        

    };

}
