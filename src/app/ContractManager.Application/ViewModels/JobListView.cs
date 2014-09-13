using System;

namespace ContractManager.Application.ViewModels
{
    public class JobListView
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public string Title { get; set; }
        public string Location { get; private set; }
    }
}
