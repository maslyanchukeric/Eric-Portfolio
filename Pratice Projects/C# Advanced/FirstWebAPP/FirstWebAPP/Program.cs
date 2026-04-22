using FirstWebAPP;

// Create and run the web host
Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>(); // Specify the Startup class to configure the application
    }).Build().Run(); // Build and run the web host

Console.WriteLine("This executes after the web server has stopped."); // This line will execute after the web server has stopped running