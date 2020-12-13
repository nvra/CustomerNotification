# CustomerNotification

The provided solution has 3 routes. The apis return data in json/xml format.

Attached is the postman collection for the below apis.

1) New User registered
https://localhost:44356/api/messaging/{userId}/new
returns InternalError 500, if any error.
returns NotFound 404, if UserId is not found.
returns BadRequest 400, if UserId provided is null or empty
returns OK 200, when the userid exists and returns the below response.

Json response

{
    "Type": "NewUserRegistered",
    "BodyType": {
        "UserId": "user3",
        "Email": "user3@abc.com",
        "FirstName": "User3First",
        "LastName": "User3Last"
    }
}

Xml response

<UserRegisteredModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <BodyType>
        <UserId>user3</UserId>
        <Email>user3@abc.com</Email>
        <FirstName>User3First</FirstName>
        <LastName>User3Last</LastName>
    </BodyType>
</UserRegisteredModel>

2) User Deleted
https://localhost:44356/api/messaging/{userId}/delete

returns InternalError 500, if any error.
returns NotFound 404, if UserId is not found.
returns BadRequest 400, if UserId provided is null or empty
returns OK 200, when the userid exists and returns the below response.

json response
{
    "Type": "UserDeleted",
    "BodyType": {
        "UserId": "user3"
    }
}

xml response
<UserDeletedModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <BodyType>
        <UserId>user3</UserId>
    </BodyType>
</UserDeletedModel>

3) User Blocked
https://localhost:44356/api/messaging/{userId}/block

returns InternalError 500, if any error.
returns NotFound 404, if UserId is not found.
returns BadRequest 400, if UserId provided is null or empty
returns OK 200, when the userid exists and returns the below response.

json response
{
    "Type": "UserAccessBlocked",
    "BodyType": {
        "UserId": "user3"
    }
}

xml response
<UserBlockedModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <BodyType>
        <UserId>user3</UserId>
    </BodyType>
</UserBlockedModel>
