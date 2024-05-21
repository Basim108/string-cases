# Hrimsoft.StringCases
![GitHub](https://img.shields.io/github/license/basim108/string-cases)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Hrimsoft.StringCases)
![Nuget](https://img.shields.io/nuget/dt/Hrimsoft.StringCases)

String extensions for converting into different cases e.g. snake_case, camelCase, kebab-case, _underscoredCamelCase, Train-Case

## Installing ##

To install [NuGet package Hrimsoft.StringCases](https://www.nuget.org/packages/Hrimsoft.StringCases) run the following command in the Package Manager Console:

```
PM> Install-Package Hrimsoft.StringCases
```
## Usage ##
```
  var snakeCase = "Some text that    could be any-kind--ofText".ToSnakeCase();
  // snakeCase = "some_text_that_could_be_any_kind_of_text"

  var camelCase = "Some text that    could be any-kind--ofText".ToCamelCase();
  // camelCase = "someTextThatCouldBeAnyKindOfText"

  var underscoredCamelCase = "Some text that    could be any-kind--ofText".ToUnderscoredCamelCase();
  // camelCase = "_someTextThatCouldBeAnyKindOfText"

  var kebabCase = "Some text that    could be any-kind--ofText".ToKebabCase();
  // kebabCase = "some-text-that-could-be-any-kind-of-text"

  var trainCase = "Some text that    could be any-kind--ofText".ToTrainCase();
  // trainCase = "Some-Text-That-Could-Be-Any-Kind-Of-Text"

  var pascalCase = "Some text that    could be any-kind--ofText".ToPascalCase();
  // pascalCase = "SomeTextThatCouldBeAnyKindOfText"
  
  var twoCapitalLetters = "countryNZ".ToSnakeCase(); // country_nz
  twoCapitalLetters = "NZ".ToSnakeCase(); // nz
  twoCapitalLetters = "GDPRisNotCCPA".ToSnakeCase(); // gdpr_is_not_ccpa
  
  var digitIsDilimiter = "GDPR1isNotCCPA".ToSnakeCase(); // gdpr_1_is_not_ccpa
  digitIsDilimiter = "1isNotCCPA".ToSnakeCase(); // 1_is_not_ccpa
  digitIsDilimiter = "1isNot2".ToSnakeCase(); // 1_is_not_2
```

## License ##

StringCases is licensed under the MIT License. See [LICENSE](LICENSE) for details.

Copyright (c) Basim Al-Jawahery
