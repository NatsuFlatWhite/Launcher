# Launcher

This launcher is a simple program that recreates the web-based login system that was used in the Korean service.

It sends the same login parameters expected by the client and launches the game, allowing automatic login without manually entering account information.

### Features

#### iamqa

Enables switching the client to the QA server branch.

#### iamshuruk

An activation key that enables integration with certain developer-only settings and debugging features.

### How It Works

When launching the game, the launcher passes a predefined login format to the client.

**Version 1.325 format**

```text
_|ID|_|Password|AuthHash
```

**Version 1.627 format**

```text
_|ID|_|Password|_|_|_|AuthHash
```

### TODO

* Refactor the authentication system so that `AuthHash` can be obtained from a real authentication service instead of using a hardcoded value.
