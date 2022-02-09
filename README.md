# Microsoft Azure Text-to-Speech Demo using Speech API
I have created a windows application using C# .Net Core and it uses Microsoft's Speech API to convert text in telugu (te-in) to speech (.wav) file. I created this project for my specific need. You can customize the application to add more languages and respective voices.

# Pre-requisites
- Microsoft Visual Studio/.Net to modify/run the application

- Speech API Service in Azure for subscription key. The subscription key and location needs to be configured in the code in order for the application to convert the text to speech.

# How it works
- This application takes the input of a text file with content in Telugu (te-in) unicode characters.
- Takes a output path for the converted speech file.
- And the voice in which you want the audio to be in.
- Once above are set, application calls speech service api and converted .wav audio file is saved into the output folder.

Note: This only converts upto 10 mins of audio. If you need to convert larger text, you can try using Long API provided in Microsoft docs. And for the Speech API take a look a the pricing tier suitable for your requirement.

# Screenshots
![image](https://user-images.githubusercontent.com/52953448/153101223-b1b97482-ea49-4da0-aa8c-502ff9e6b69c.png)


# References
I have followed the example provided here:

https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/get-started-text-to-speech?tabs=script%2Cbrowserjs%2Cwindowsinstall&pivots=programming-language-csharp
