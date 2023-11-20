# Telegram Text Extractor (TTE)

TelegramTextExtractor is a simple console application written in C# that facilitates the extraction of text from Telegram chat history export data in JSON format. This tool allows you to convert the exported data into a large continuous corpus, making it easier to analyze or process the text.

## Features

- **JSON Parsing:** TelegramTextExtractor parses the JSON format of Telegram chat history export data, extracting relevant information such as messages, sender IDs, timestamps, and more if needed for your usecase you can modify the code to include those fields.

- **Text Extraction:** The application focuses on extracting the text content from the messages, providing a clean and concise corpus for further analysis.

- **Continuous Corpus Output:** The extracted text is formatted into a large continuous corpus, making it suitable for various natural language processing (NLP) tasks or text analysis.

## Requirements

- .NET SDK or Runtime

## Usage

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/kerodkibatu/TelegramTextExtractor.git
    ```

2. Navigate to the project directory:

    ```bash
    cd TelegramTextExtractor
    ```

3. Build the project:

    ```bash
    dotnet build
    ```

4. Run the application with the path to your Telegram chat history export JSON file as an argument:

    ```bash
    dotnet run
    ```

5. Specify the Output root path(if applicable) and paste the path to the chat export json.

## Notice

This program is part of a larger NLP project which you can get the details for over at my [Telegram](t.me/dotnetWarrior), You can also check out my [Youtube](youtube.com/@kerverse) for more content.

## Disclaimer

TelegramTextExtractor is provided as-is, without any warranty. Use it responsibly and ensure compliance with Telegram's terms of service.

## Contributing

Feel free to contribute to this project by opening issues or submitting pull requests. Your feedback and contributions are highly appreciated.

## License

This project is licensed under the Apache 2.0 License - see the [LICENSE](LICENSE.txt) file for details.
