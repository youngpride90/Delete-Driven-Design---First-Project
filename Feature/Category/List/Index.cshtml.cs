using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DDDFirst.Feature.Category.List
{
    public class IndexModel : PageModel
    {
        private readonly IMediator _mediator;
        public IndexModel(IMediator mediator)
        {
            _mediator = mediator;
        }
        public ViewModel Data { get; set; }
        public async Task OnGetAsync(Query query)
        {
            Data = await _mediator.Send(query);
            
        }
    }
}
