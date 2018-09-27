# ApplicationToActivityMapper
This is a helper-project written in C# that maps application data (process-name, window-titles) to an activity (e.g. coding, work unrelated webbrowsing, email). It was originally developed for and is used in [PersonalAnalytics](https://github.com/sealuzh/PersonalAnalytics).

We are currently porting it from the PersonalAnalytics project to a separate project over here. As soon as it's ready, it will be released to the Nuget package manager, for easy re-use. Since we're porting it from the .Net Framework 4.5 to .Net Core 2.0, it can also be run on Mac/Linux in the future.

The mapping is based on work by André N. Meyer, Gail C. Murphy, Thomas Zimmermann and Thomas Fritz, and their publication titles ["The work life of developers: activities, switches and perceived productivity"](https://github.com/sealuzh/ApplicationToActivityMapper/blob/master/documentation/productiveWorkday_TSE17_preprint.pdf), as published in the Transactions on Software Engineering Journal in 2017. The mapping scheme is described in more detail in the publication's [appendix](https://github.com/sealuzh/ApplicationToActivityMapper/blob/master/documentation/productiveWorkday-TSE17_appendix.pdf)

# Contact
André Meyer (ameyer@ifi.uzh.ch)
