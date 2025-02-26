﻿using CommunityToolkit.Mvvm.ComponentModel;
using MoocDownloader.Models;
using System;
using System.Collections.ObjectModel;

namespace MoocDownloader.ViewModels;

/// <summary>
/// The view model of the queue view.
/// </summary>
[INotifyPropertyChanged]
public partial class QueueViewModel
{
    [ObservableProperty] private ObservableCollection<Course> _queues = new();

    public QueueViewModel()
    {
        for (var i = 0; i < 10; i++)
        {
            Queues.Add(new()
            {
                CourseName = "PhotoShop 图形图像处理技术",
                DownloadUrl = "https://www.icourse163.org/course/WSPC-1002698010?tid=1467126645",
                CoverImage = "https://edu-image.nosdn.127.net/676ebc38ef534767a05ab31472cd5374.jpg",
                CreationTime = DateTime.Now,
                FinishedTime = DateTime.Now,
                CourseState = CourseState.Downloading,
                Introduction = "该课程于2020年11月被教育部认定为国家级精品在线开放课程（高职）",
                CompletedCount = 10,
                TotalCount = 55,
                TotalSize = 10240000,
            });
        }
    }
}