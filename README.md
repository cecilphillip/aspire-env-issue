## Override Environment Variables
[Github Issue](https://github.com/dotnet/aspire/issues/3932)

App Request

```shell
> curl https://{apiservice}/dump-config
```

Should return

```json
{
  "env":"http://localhost:4318",
  "conf":"http://localhost:4318"
}
```

Debugger view

<img width="756" alt="Screenshot 2024-04-24 at 6 50 03 PM" src="https://github.com/cecilphillip/aspire-env-issue/assets/350882/050145d0-c994-4e74-b650-e43c0b7f18c2">


Dashboard view

<img width="603" alt="Screenshot 2024-04-24 at 6 33 53 PM" src="https://github.com/cecilphillip/aspire-env-issue/assets/350882/3d7c7a3d-f470-421d-a0a9-e270bf9702b0">
