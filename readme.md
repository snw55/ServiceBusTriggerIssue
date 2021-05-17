# Function /w Service Bus Trigger Log Filler

Steps to reproduce:

1. Create new Azure resource group

2. Provision temporary Azure test resources:
    ```ps
    $resourceGroupName = "your-rsg"
    New-AzResourceGroupDeployment -ResourceGroupName $resourceGroupName -TemplateFile ".\arm-template.json" -Name (New-Guid).ToString()
    ```

3. Update `local.settings.json` and set ServiceBusSettings:ServiceBusConnection to newly provisioned Service Bus SAS policy connection string.

4. Run application:
```
func start
```

5. Error galore!