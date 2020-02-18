# Data Syncer #

Data syncer is a data syncing engine developed to sync data betweeen different databases in real time. It has a windows service implementation to take care of starting the syncing service every minute.

*Currently I am working to make this repository a more general solution as it was developed with a specific problem and client in mind when originally created.*

## Goals for this project: ##

- [] Add support for direct "convention based mapping".
- [] Add Postgres data class support.
- [] Add MongoDb data class support.
- [] Add SqlLite data class support.

## Completed so far. ##

- [x] Added a mapping class.
- [x] Added a Data Syncing class for MSSQL
- [x] Added Data Syncing class for MySQL

