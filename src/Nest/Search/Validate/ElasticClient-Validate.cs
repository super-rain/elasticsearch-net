﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace Nest
{
	public partial class ElasticClient
	{
		/// <inheritdoc/>
		public IValidateResponse Validate<T>(Func<ValidateQueryDescriptor<T>, ValidateQueryDescriptor<T>> querySelector)
			where T : class
		{
			return this.Dispatcher.Dispatch<ValidateQueryDescriptor<T>, ValidateQueryRequestParameters, ValidateResponse>(
				querySelector,
				(p, d) => this.LowLevelDispatch.IndicesValidateQueryDispatch<ValidateResponse>(p, d)
			);
		}

		/// <inheritdoc/>
		public IValidateResponse Validate(IValidateQueryRequest validateQueryRequest)
		{
			return this.Dispatcher.Dispatch<IValidateQueryRequest, ValidateQueryRequestParameters, ValidateResponse>(
				validateQueryRequest,
				(p, d) => this.LowLevelDispatch.IndicesValidateQueryDispatch<ValidateResponse>(p, d)
			);
		}

		/// <inheritdoc/>
		public Task<IValidateResponse> ValidateAsync<T>(Func<ValidateQueryDescriptor<T>, ValidateQueryDescriptor<T>> querySelector)
			where T : class
		{
			return this.Dispatcher.DispatchAsync<ValidateQueryDescriptor<T>, ValidateQueryRequestParameters, ValidateResponse, IValidateResponse>(
				querySelector,
				(p, d) => this.LowLevelDispatch.IndicesValidateQueryDispatchAsync<ValidateResponse>(p, d)
			);
		}

		/// <inheritdoc/>
		public Task<IValidateResponse> ValidateAsync(IValidateQueryRequest validateQueryRequest)
		{
			return this.Dispatcher.DispatchAsync<IValidateQueryRequest, ValidateQueryRequestParameters, ValidateResponse, IValidateResponse>(
				validateQueryRequest,
				(p, d) => this.LowLevelDispatch.IndicesValidateQueryDispatchAsync<ValidateResponse>(p, d)
			);
		}
	}
}