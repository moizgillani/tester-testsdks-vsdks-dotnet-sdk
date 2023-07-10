# Fixed Wireless Qualification

```csharp
FixedWirelessQualificationController fixedWirelessQualificationController = client.FixedWirelessQualificationController;
```

## Class Name

`FixedWirelessQualificationController`


# Domestic 4 G and 5G Fixed Wireless Qualification

Use this query for Fixed Wireless Qualification of an address. Network types include: LTE, C-BAND and MMWAVE.

```csharp
Domestic4GAnd5gFixedWirelessQualificationAsync(
    Models.GetWirelessCoverageRequestFWA body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.GetWirelessCoverageRequestFWA`](../../doc/models/get-wireless-coverage-request-fwa.md) | Body, Required | Request for network coverage details. |

## Response Type

[`Task<ApiResponse<Models.WNPRequestResponse>>`](../../doc/models/wnp-request-response.md)

## Example Usage

```csharp
GetWirelessCoverageRequestFWA body = new GetWirelessCoverageRequestFWA
{
    AccountName = "0000123456-00001",
    RequestType = "FWA",
    LocationType = "ADDRESS",
    Locations = new Locations
    {
    },
    NetworkTypesList = new List<Models.NetworkType>
    {
        new NetworkType
        {
            NetworkTypeProp = "LTE",
        },
    },
};

try
{
    ApiResponse<WNPRequestResponse> result = await fixedWirelessQualificationController.Domestic4GAnd5gFixedWirelessQualificationAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WNPRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |

