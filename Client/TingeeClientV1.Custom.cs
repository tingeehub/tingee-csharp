#nullable enable

using Tingee.Sdk.Http;
using Tingee.Sdk.Types;

namespace Tingee.Sdk.Client;

public sealed class TingeeV1CustomMethods : TingeeClient.V1Methods
{
    internal TingeeV1CustomMethods(TingeeHttpClient httpClient) : base(httpClient) { }
}
