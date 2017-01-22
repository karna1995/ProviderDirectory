﻿using System;
using System.Web.Http;
using MediatR;
using Octogami.ProviderDirectory.Application.Feature.CreateProvider;
using Octogami.ProviderDirectory.Application.Feature.GetProvider;

namespace Octogami.ProviderDirectory.Web.Controllers.api
{
	public class ProviderController : ApiController
	{
		private readonly IMediator _mediator;

		public ProviderController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[Route("api/Providers")]
		public IHttpActionResult PostProvider(CreateProviderCommand command)
		{
			var response = _mediator.Send(command);
			return Ok(response);
		}

		[Route("api/Providers/{providerId}")]
		public IHttpActionResult GetProvider(Guid providerId)
		{
			var response = _mediator.Send(new GetProviderQuery {ProviderId = providerId});
			return Ok(response);
		}
	}
}