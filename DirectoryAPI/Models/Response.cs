﻿namespace DirectoryAPI.Models
{
    public class Response
    {
        public bool Status { get; set; }
        public string? Message { get; set; }

        public object? Data { get; set; }
    }
}
