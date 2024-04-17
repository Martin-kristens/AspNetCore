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
    public SubscriberDto Subscribe { get; set; } = new SubscriberDto(){ };
}