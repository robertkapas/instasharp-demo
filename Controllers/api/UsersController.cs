﻿using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstaSharp.Samples.MVC.Controllers.api
{
    public class UsersController : Controller
    {
        readonly InstaSharp.Endpoints.Users _users;

        public UsersController()
        {
            _users = new Endpoints.Users(InstaSharpConfig.Instance.config, InstaSharpConfig.Instance.oauthResponse);
        }

        [GET("api/users/{id}")]
        public ContentResult UserInfo(string id) {
            var user = string.IsNullOrEmpty(id) ? _users.Get() : _users.Get(id);

            return new ContentResult { Content = user.Content, ContentType = "application/json" };
        }

        [GET("api/self/feed")]
        public ContentResult Feed(string next_max_id) {

            var feed = next_max_id == null ? _users.Feed() : _users.Feed(next_max_id);

            return new ContentResult { Content = feed.Content, ContentType = "application/json" };

        }
        [GET("api/self/recent")]
        public ContentResult RecentSelf(string next_max_id) {

            var recent = next_max_id == null ? _users.RecentSelf() : _users.RecentSelf(next_max_id);

            return new ContentResult { Content = recent.Content, ContentType = "application/json" };
        }

        [GET("api/users/{id}/recent")]
        public ContentResult Recent(string id) {

            var recent = _users.Recent(id);

            return new ContentResult { Content = recent.Content, ContentType = "application/json" };

        }
    }
}
