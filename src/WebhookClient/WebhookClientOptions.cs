﻿namespace WebhookClient;

public class WebhookClientOptions
{
    public string Token { get; set; }
    public string SelfUrl { get; set; }
    public bool ValidateToken { get; set; }
}
