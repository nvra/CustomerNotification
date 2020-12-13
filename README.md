# CustomerNotification

The provided solution has 3 routes. The apis return data in json/xml format.

Attached is the postman collection for the below apis. 
The data for this api is from the file at "CustomerNotification\CustomerNotification.API\Data\data.json" This sample data.json file contains 5 users with ids in the format "9f9b1a81-2f94-44b7-994d-50cb60738f93", "9f9b1a81-2f94-44b7-994d-50cb60738f94"

1) New User registered
https://localhost:44356/api/messaging/{userId}/new
returns InternalError 500, if any error.
returns NotFound 404, if UserId is not found.
returns BadRequest 400, if UserId provided is null or empty
returns OK 200, when the userid exists and returns the below response.

Json response

{
    "MessageType": "NewUserRegistered",
    "Data": {
        "UserId": "9f9b1a81-2f94-44b7-994d-50cb60738f93",
        "Email": "user3@abc.com",
        "FirstName": "User3First",
        "LastName": "User3Last"
    }
}

Xml response
For xml response, use the below headers.
Accept: application/xml
Content-Type: application/xml

<UserRegisteredModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <Data>
        <UserId>9f9b1a81-2f94-44b7-994d-50cb60738f93</UserId>
        <Email>user3@abc.com</Email>
        <FirstName>User3First</FirstName>
        <LastName>User3Last</LastName>
    </Data>
</UserRegisteredModel>

UserId not found response
<string>User Id does not exist.</string>

Sample BadRequest 400 response
{
    "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
    "title": "One or more validation errors occurred.",
    "status": 400,
    "traceId": "|b5db0e3c-4e4f5c186f9ce518.",
    "errors": {
        "userId": [
            "The value 'user3' is not valid."
        ]
    }
}

2) User Deleted
https://localhost:44356/api/messaging/{userId}/delete

returns InternalError 500, if any error.
returns NotFound 404, if UserId is not found.
returns BadRequest 400, if UserId provided is null or empty
returns OK 200, when the userid exists and returns the below response.

json response
{
    "MessageType": "UserDeleted",
    "Data": {
        "UserId": "9f9b1a81-2f94-44b7-994d-50cb60738f93"
    }
}

xml response
<UserDeletedModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <Data>
        <UserId>9f9b1a81-2f94-44b7-994d-50cb60738f93</UserId>
    </Data>
</UserDeletedModel>

3) User Blocked
https://localhost:44356/api/messaging/{userId}/block

returns InternalError 500, if any error.
returns NotFound 404, if UserId is not found.
returns BadRequest 400, if UserId provided is null or empty
returns OK 200, when the userid exists and returns the below response.

json response
{
    "MessageType": "UserAccessBlocked",
    "Data": {
        "UserId": "9f9b1a81-2f94-44b7-994d-50cb60738f93"
    }
}

xml response
<UserBlockedModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <Data>
        <UserId>9f9b1a81-2f94-44b7-994d-50cb60738f93</UserId>
    </Data>
</UserBlockedModel>
