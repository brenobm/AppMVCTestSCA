﻿using Microsoft.Owin;
using Owin;


namespace AppMVCTestSCA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
