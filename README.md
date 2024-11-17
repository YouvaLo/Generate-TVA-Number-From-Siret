# Verify-Siret and Generate-TVA 

This code is written in C# .NET and calculates the intra-Community VAT number of a company in France from its Siret number, as well as checking the validity of the Siret number. 

## Installation : 

To start using this project, follow these steps to install the necessary dependencies.

1. **Clone the repository** :

    ```bash
    git clone https://github.com/YouvaLo/generate-tva-number-from-siret.git
    cd generate-tva-number-from-siret

2. **Install dependencies

    ```bash 
    dotnet add package Microsoft.Extensions.DependencyInjection
    dotnet add package Microsoft.Extensions.Hosting

---------------------------------------------------------------------------------------------------------------

This code is used to generate a company's French VAT number from its siret (or siren) number. 

## Example : 
    
    French TVA : FR 68 775701485 --> FR : Country code, 68 : Control Key, 775701485 : Siren 

---------------------------------------------------------------------------------------------------------------

This Code also enables you to check the validity of the Siret number, based on the Luhn algorithm. 

## Explanation of the Luhn algorithm : 

    Step1 : Check that the SIRET is 14 digits long.
    
    Step2 : Scroll through the digits from right to left.
    
    Step3 : Digits with an odd index are multiplied by two (hence the Temp variable, which is false when the index is even and true when the index is odd).

    Step4 : The result of this multiplication by two, if is greater than 9, we subtract 9 otherwise we keep it as it is. 
    
    Step5 : We add up all the results.
    
    Step6 : If the total sum is a multiple of 10, then the siret is valid. 

---------------------------------------------------------------------------------------------------------------

## Generate TVA Examples 

### Example 1 

    Input : siret = "775701" 
    Output : No tva number, because the siret number is invalid (siret length less than 14) 


### Example 2 

    Input : siret = "12345678912345"
    Output : No TVA number, because the siret number is invalid (Luhn algorithm returns false)

### Example 3

    Input : siret = "77570148500101"
    Output : TVA number = "FR68775701485" 
