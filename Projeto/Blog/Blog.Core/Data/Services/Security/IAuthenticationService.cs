﻿using Blog.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Data.Services.Security
{
    public partial interface IAuthenticationService
    {
        /// <summary>
        /// Sign in
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <param name="createPersistentCookie">A value indicating whether to create a persistent cookie</param>
        void SignIn(Usuarios customer, bool createPersistentCookie);

        /// <summary>
        /// Sign out
        /// </summary>
        void SignOut();

        /// <summary>
        /// Get authenticated customer
        /// </summary>
        /// <returns>Customer</returns>
        Usuarios GetAuthenticatedCustomer();
    }
}