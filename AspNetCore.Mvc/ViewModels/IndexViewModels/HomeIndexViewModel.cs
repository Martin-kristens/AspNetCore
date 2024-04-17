using AspNetCore.Mvc.Dtos;
using AspNetCore.Mvc.Models.Sections;
using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.ViewModels.IndexViewModels;

public class HomeIndexViewModel()
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
                Link = new LinkViewModel { ControllerName = "Downloads", ActionName = "AppleStore", Text = ""},
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
                Link = new LinkViewModel { ControllerName = "Downloads", ActionName = "GooglePlay"},
                LinkImages = new ImageViewModel { ImageUrl = "images/googleplay.svg", AltText = "google store logo"}
            },
        }
    };

    public IntegrateToolViewModel IntegrateTool { get; set; } = new IntegrateToolViewModel
    {
        Id = "integrate-tool",
        Title = "Integrate Top Work Tools",
        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin volutpat mollis egestas. Nam luctus facilisis ultrices. Pellentesque volutpat ligula est. Mattis fermentum, at nec lacus.",
        ToolBox =
        [
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/google-icon.svg", AltText = "google icon" },
                BoxText = "Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis."
            },
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/camera.svg", AltText = "camera icon" },
                BoxText = "In eget a mauris quis. Tortor dui tempus quis integer est sit natoque placerat dolor."
            },
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/color-circle.svg", AltText = "color-circle icon" },
                BoxText = "Id mollis consectetur congue egestas egestas suspendisse blandit justo."
            },
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/mail-icon.svg", AltText = "mail-box icon" },
                BoxText = "Rutrum interdum tortor, sed at nulla. A cursus bibendum elit purus cras praesent."
            },
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/icon-5.svg", AltText = "blue circle icon" },
                BoxText = "Congue pellentesque amet, viverra curabitur quam diam scelerisque fermentum urna."
            },
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/monkey-head.svg", AltText = "monkey head icon" },
                BoxText = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris."
            },
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/drop-box-icon.svg", AltText = "dropbox icon" },
                BoxText = "Ut in turpis consequat odio diam lectus elementum. Est faucibus blandit platea."
            },
            new ToolBoxViewModel()
            {
                Image = new ImageViewModel() { ImageUrl = "../icons/elephant-head.svg", AltText = "green elephant head icon" },
                BoxText = "Faucibus cursus maecenas lorem cursus nibh. Sociis sit risus id. Sit facilisis dolor arcu."
            },
        ]



    };

    public SubscriberDto Subscribe { get; set; } = new SubscriberDto(){ };
}