﻿using Microsoft.Extensions.Options;
using N3O.Umbraco.Authentication.Auth0.Options;
using System;
using System.Threading;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace N3O.Umbraco.Authentication.Auth0.Notifications;

public class UserSaving : INotificationAsyncHandler<UserSavingNotification> {
    private readonly Lazy<IUserDirectory> _userDirectory;
    private readonly Auth0BackOfficeAuthenticationOptions _auth0BackOfficeOptions;

    public UserSaving(Lazy<IUserDirectory> userDirectory,
                      IOptions<Auth0BackOfficeAuthenticationOptions> auth0BackOfficeOptions) {
        _userDirectory = userDirectory;
        _auth0BackOfficeOptions = auth0BackOfficeOptions.Value;
    }

    public async Task HandleAsync(UserSavingNotification notification, CancellationToken cancellationToken) {
        if (_auth0BackOfficeOptions.AutoCreateDirectoryUser) {
            foreach (var user in notification.SavedEntities) {
                await _userDirectory.Value.CreateUserIfNotExistsAsync(_auth0BackOfficeOptions.ClientId,
                                                                      _auth0BackOfficeOptions.ConnectionName,
                                                                      user.Email,
                                                                      user.Name,
                                                                      lastName: null);
            }
        }
    }
}