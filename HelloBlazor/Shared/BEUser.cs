using System;
namespace HelloBlazor.Shared
{
    public class BEUser
    {
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public bool IsCoordinator { get; set; } = false;
    }
}

