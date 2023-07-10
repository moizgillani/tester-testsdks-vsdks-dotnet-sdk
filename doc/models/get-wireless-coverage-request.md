
# Get Wireless Coverage Request

## Structure

`GetWirelessCoverageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` |
| `RequestType` | `string` | Required | **Constraints**: *Minimum Length*: `2`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{2,12}$` |
| `LocationType` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{3,12}$` |
| `Locations` | [`Models.Locationscoord`](../../doc/models/locationscoord.md) | Required | - |
| `NetworkTypesList` | [`List<Models.NetworkType>`](../../doc/models/network-type.md) | Required | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "requestType": "NW",
  "locationType": "LONGLAT",
  "locations": {
    "coordinatesList": [
      {
        "latitude": "-33.84819",
        "longitude": "151.22049"
      }
    ]
  },
  "networkTypesList": [
    {
      "networkType": "LTE"
    }
  ]
}
```

