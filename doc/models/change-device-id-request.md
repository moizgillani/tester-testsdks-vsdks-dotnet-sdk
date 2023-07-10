
# Change Device Id Request

Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.

## Structure

`ChangeDeviceIdRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AssignNonGeoMdn` | `bool?` | Optional | Set to true to assign a non-Geo MDN and MSISDN, or false to assign an MDN and MSISDN from a specific NPA-NXX. |
| `Change4gOption` | `string` | Optional | The type of change that you want to make for a 4G device. |
| `DeviceIds` | [`List<Models.DeviceId>`](../../doc/models/device-id.md) | Optional | The device that you want to change, specified by a device identifier. |
| `DeviceIdsTo` | [`List<Models.DeviceId>`](../../doc/models/device-id.md) | Optional | The new identifier for the device. Required for all change4GOptions except ChangeMSISDN. |
| `NpaNxx` | `string` | Optional | The NPA NXX (area code and prefix) from which the MDN and MSISDN will be derived when assignNonGeoMDN is false. Specify the 6-digit NPA NXX of the location where the line of service will primarily be used. This API checks to see if a number starting with the NPA NXX is available. If not, this API uses the zipCode parameter, if specified, to assign a number in the area of the line of service. This parameter is required when you change an MDN/MSISDN for a B2B carrier, such as Verizon Wireless. |
| `ServicePlan` | `string` | Optional | The code for a different service plan, if you want to change the service plan while changing the device identifier. Set this parameter to one of the Code values returned by GET /plans. |
| `ZipCode` | `string` | Optional | The ZIP code from which the MDN and MSISDN will be derived when assignNonGeoMDN is true. Specify the zip code of the location where the line of service will primarily be used. |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "42590078891480000008",
      "kind": "iccid"
    }
  ],
  "change4gOption": "ChangeMSISDN",
  "assignNonGeoMdn": false,
  "npaNxx": "509393",
  "servicePlan": "M2M2GB",
  "deviceIdsTo": [
    {
      "id": "id8",
      "kind": "kind6"
    },
    {
      "id": "id9",
      "kind": "kind7"
    }
  ]
}
```
