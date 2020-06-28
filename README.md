## Dotnet POCs

#### This is an environment for doing POCs(Proof of Concepts) in dotnet

### webapi

- Contains a basic web api project

### webapi-test

- Contains tests for webapi

### regression tests

- You may run regression tests through a postman collection using the following command. Make sure the regression test is communicating with a domain and not localhost IP.
- `docker run -p 5001:5001 -v ${ABSOLUTEPATH}/regression:/app -w /app postman/newman run regression-tests.json`
