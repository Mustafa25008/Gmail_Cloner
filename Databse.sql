Create Database Gmail;
Use Gmail;

Create Table Users(

username varchar(50) Primary key,
password varchar(50)

);


CREATE TABLE EmailRecords (
    EmailID INT IDENTITY(1,1) PRIMARY KEY,
    FromEmail VARCHAR(50) NOT NULL,
    ToEmail VARCHAR(50) NOT NULL,
    Subject NVARCHAR(255) NOT NULL,
    Message NVARCHAR(MAX) NOT NULL,
    DateSent DATETIME NOT NULL,
    Status VARCHAR(50) NOT NULL,
	Identity1 VARCHAR(50),
    CONSTRAINT FK_FromEmail FOREIGN KEY (FromEmail) REFERENCES Users(username)--,
    --CONSTRAINT FK_ToEmail FOREIGN KEY (ToEmail) REFERENCES Users(username)
);

CREATE TABLE CompanyEmails (
    Id INT PRIMARY KEY IDENTITY,      -- Unique identifier for each entry
    CompanyName VARCHAR(50) NOT NULL,  -- Name of the company
    ContactEmail VARCHAR(50) NOT NULL unique, -- Contact email address of the company
    Website VARCHAR(50),               -- Website of the company
	Password VARCHAR(50)
);
-- Insert more example data into the table without the PhoneNumber column
INSERT INTO CompanyEmails (CompanyName, ContactEmail, Website)
VALUES
('Google', 'support@google.com', 'https://www.google.com'),
('Microsoft', 'support@microsoft.com', 'https://www.microsoft.com'),
('Apple', 'support@apple.com', 'https://www.apple.com'),
('Netflix', 'support@netflix.com', 'https://www.netflix.com'),
('Twitter', 'support@twitter.com', 'https://www.twitter.com'),
('LinkedIn', 'support@linkedin.com', 'https://www.linkedin.com'),
('Spotify', 'support@spotify.com', 'https://www.spotify.com'),
('Uber', 'support@uber.com', 'https://www.uber.com'),
('Airbnb', 'support@airbnb.com', 'https://www.airbnb.com'),
('Salesforce', 'support@salesforce.com', 'https://www.salesforce.com'),
('Adobe', 'support@adobe.com', 'https://www.adobe.com'),
('Slack', 'support@slack.com', 'https://www.slack.com'),
('Zoom', 'support@zoom.us', 'https://www.zoom.us'),
('Dropbox', 'support@dropbox.com', 'https://www.dropbox.com'),
('Shopify', 'support@shopify.com', 'https://www.shopify.com'),
('PayPal', 'support@paypal.com', 'https://www.paypal.com'),
('Oracle', 'support@oracle.com', 'https://www.oracle.com'),
('IBM', 'support@ibm.com', 'https://www.ibm.com'),
('Tesla', 'support@tesla.com', 'https://www.tesla.com'),
('Samsung', 'support@samsung.com', 'https://www.samsung.com'),
('Facebook', 'support@facebook.com', 'https://www.facebook.com');
Update CompanyEmails Set Password = '12345';


CREATE TABLE EmailRecords2 (
    EmailID INT IDENTITY(1,1) PRIMARY KEY,
    FromEmail VARCHAR(50) NOT NULL,
    ToEmail VARCHAR(50) NOT NULL,
    Subject NVARCHAR(255) NOT NULL,
    Message NVARCHAR(MAX) NOT NULL,
    DateSent DATETIME NOT NULL,
    Status VARCHAR(50) NOT NULL,
	Identity1 VARCHAR(50),
    FOREIGN KEY (FromEmail) REFERENCES CompanyEmails(ContactEmail)--,
--    FOREIGN KEY (ToEmail) REFERENCES CompanyEmails(ContactEmail)
);
