# OpenAI SDK for .NET: Getting Started Tutorial

## Introduction

This repository provides a simple introduction to using the [OpenAI SDK for .NET](https://github.com/openai/openai-dotnet) through a console application. You will learn how to set up the OpenAI ChatClient, use the completitions API and implement chat history to recall context from previous turns.

## Prerequisites

Before you begin, make sure you have the following:

- [.NET 8.0 SDK or later](https://dotnet.microsoft.com/download)
- An API key from OpenAI. You can obtain this by creating an account at [OpenAI's platform](https://platform.openai.com/api-keys).

## Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/ndamulelonemakh/openai-net-starter.git
   ```

2. Install the OpenAI SDK for .NET using NuGet:
   ```bash
   cd openai-net-starter
   dotnet add package OpenAI
   ```

## Environment Setup

To interact with OpenAI, you need an API key. Set it up in your environment as follows:

**Windows**
```bash
setx OPENAI_API_KEY "YOUR_API_KEY_HERE"
```

**Linux/macOS**
```bash
export OPENAI_API_KEY="YOUR_API_KEY_HERE"
```

## Usage

2. **How to Run**

   - Open your terminal, navigate to the directory containing the project, and run:
   
     ```bash
     dotnet run
     ```

   - You will be prompted to enter a message. Enter any message you want, and the assistant will respond.
   
   - Type `exit` to end the session. 

## How It Works

- The application uses a `ChatClient` to interact with the OpenAI model (e.g., GPT-4).
- User input is taken from the console and added to a conversation history (`chatHistory`) to maintain context over multiple turns.
- Each input is passed to the [OpenAI REST API](https://platform.openai.com/docs/api-reference), and the response is displayed back to the user.
- The conversation continues until the user types "exit".

## Notes

- Remember to use a valid API key and handle your credentials securely.
- This project is intended as an introductory example, suitable for expanding into more sophisticated .NET applications.

## Contributing

Feel free to open issues or pull requests for suggestions and improvements. Contributions are always welcome!

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

If you have any questions, reach out via the [Issues tab]()


---

# References

* [Dotnet Scripted Install for Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#scripted-install)
