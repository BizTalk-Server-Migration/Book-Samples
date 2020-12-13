# Support for Always Encrypted
BizTalk Server 2020 allows you to connect to the Always Encrypted column in SQL Server. This feature was part of BizTalk Server 2016 Feature Pack 1 (only available in Enterprise Edition) but it is now installed with the BizTalk Server 2020 default installation process and available across all editions.

Data can be fetched using the WCF-SQL adapter in either encrypted or hashed format. The ColumnEncryptionSetting binding property enables or disables the functionality to get decrypted/encrypted column values from an Always Encrypted database.

When the ColumnEncryptionSetting binding is set to Disabled (default), the SQL adapter disables Always Encrypted for the query. When set to Enabled, the SQL adapter enables Always Encrypted for the query.