using AspNetCore.Mvc.Models.Components;
using AspNetCore.Mvc.Models.Sections;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Ultimate Task Management Assistant";
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel
    {
        Id = "overview",
        ShowcaseImage = new() { ImageUrl = "images/image.svg", AltText = "Task management assitant" },
        Title = "Task Management Assistant You Gonna Love",
        Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
        Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",
        Brands =
                 [
                     new() { ImageUrl = "images/brand_1.svg", AltText = "Brand name 1" },
                     new() { ImageUrl = "images/brand_2.svg", AltText = "Brand name 2" },
                     new() { ImageUrl = "images/brand_3.svg", AltText = "Brand name 3" },
                     new() { ImageUrl = "images/brand_4.svg", AltText = "Brand name 4" },
                 ],
    };

    public FeatureViewModel Features { get; set; } = new FeatureViewModel
    {
        Id = "features",
        Title = "What Do You Get with Our Tool?",
        Text = "Make sure all your tasks are organized so you can set the priorities and focus on important. Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
        FeatureBox =
        [
            new FeatureBoxViewModel() {
                Image = new ImageViewModel() { ImageUrl = "images/chat.svg", AltText = "Features 1" },
                BoxText = "Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
                Subheading = "Comments on Tasks"
            },

            new FeatureBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/chat.svg", AltText = "Features 2" },
                BoxText = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate.",
                Subheading = "Tasks Analytics"
            },

            new FeatureBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/features3.svg", AltText = "Features 3" },
                BoxText = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.",
                Subheading = "Multiple Assignees"
            },

            new FeatureBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/features4.svg", AltText = "Features 4" },
                BoxText = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra.",
                Subheading = "Notifications"
            },

            new FeatureBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/features5.svg", AltText = "Features 5" },
                BoxText = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus.",
                Subheading = "Sections & Subtasks"
            },

            new FeatureBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/features6.svg", AltText = "Features 6" },
                BoxText = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras.",
                Subheading = "Data Security"
            },
        ]
    };

    public SwitchBlackAndWhiteViewModel DarkAndLight { get; set; } = new SwitchBlackAndWhiteViewModel
    {
        Id = "switch-black-white",
        Title = "Switch between Light & Dark Mode",
        Image =
        {
            new () {ImageUrl = "images/laptop.svg", AltText = "laptop" },
            new () {ImageUrl = "circle-in-laptop", AltText = "circle" },
        }
    };

    public TaskManagementViewModel TaskManagement { get; set; } = new TaskManagementViewModel
    {
        Id = "task - management",
        Dashboard = new() { ImageUrl = "images/task-management-img.svg", AltText = "dashboard" },
        Title = "Manage Your Work",
        TaskBox =
        [
            new TaskManagementBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/bx-check-circle.svg", AltText = "circle with checkmarks" },
                Text = "Powerful project management"
            },
            new TaskManagementBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/bx-check-circle.svg", AltText = "circle with checkmarks" },
                Text = "Transparent work management"
            },
            new TaskManagementBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/bx-check-circle.svg", AltText = "circle with checkmarks" },
                Text = "Manage work & focus on the most important tasks"
            },
            new TaskManagementBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/bx-check-circle.svg", AltText = "circle with checkmarks" },
                Text = "Track your progress with interactive charts"
            },
            new TaskManagementBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "images/bx-check-circle.svg", AltText = "circle with checkmarks" },
                Text = "Easiest way to track time spent on tasks"
            },

        ],
        Link = new() { ControllerName = "LearnMore", ActionName = "Index", Text = "Learn more" },
    };

    public DownloadAppViewModel DownloadApp { get; set; } = new DownloadAppViewModel
    {
        Id = "download-app",
        MobileImg = new() { ImageUrl = "images/mobile-img-app.svg", AltText = "mobile phone" },
        Title = "Download Our App for Any Devices:",
        AppDownload = new List<DownloadAppBoxViewModel>
        {
            new DownloadAppBoxViewModel
            {
                AppStore = "App Store",
                RatingImg =
                    [
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                    ],
                Subheading = "Editor's Choice",
                Ratings = "rating 4.7, 187K+ reviews",
                Link = new LinkViewModel { ControllerName = "", ActionName = "", Text = ""},
                LinkImages = new ImageViewModel { ImageUrl = "images/appstore.svg", AltText = "appstore logo"}
            },
              new DownloadAppBoxViewModel
            {
                AppStore = "Google Store",
                RatingImg =
                    [
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                        new() { ImageUrl = "images/rating-star.svg", AltText = "yellow star" },
                    ],
                Subheading = "App of the Day",
                Ratings = "rating 4.8, 30K+ reviews",
                Link = new LinkViewModel { ControllerName = "", ActionName = ""},
                LinkImages = new ImageViewModel { ImageUrl = "images/googleplay.svg", AltText = "google store logo"}
            },
        }
    };
}