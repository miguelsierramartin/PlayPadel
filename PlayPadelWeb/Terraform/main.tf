provider "azurerm" {
  features{}
}

resource "azurerm_resource_group" "PlayPadel-Sta" {
  name     = "PlayPadel-staging"
  location = var.location

}

resource "azurerm_resource_group" "PlayPadel-Prod" {
  name     = "PlayPadel-prod"
  location = var.location

}
#Definimos el app service plan que queremos crear 
resource "azurerm_app_service_plan" "PlayPadelASP-Sta" {
  name                = "ASP-PlayPadelstaging"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name

  sku {
    tier = "Free"
    size = "F1"
  }
}

#Definimos el app service plan que queremos crear 
resource "azurerm_app_service_plan" "PlayPadelASP-Prod" {
  name                = "ASP-PlayPadelprod"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name

  sku {
    tier = "Free"
    size = "F1"
  }
}

#Definimos el app service Catalog

resource "azurerm_app_service" "app_service_catalog_staging" {
  name                = "pp-catalogSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_catalog_production" {
  name                = "pp-catalogProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos el app service Identity

resource "azurerm_app_service" "app_service_identity_staging" {
  name                = "pp-identitySta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_identity_production" {
  name                = "pp-identityProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos el app service Customer

resource "azurerm_app_service" "app_service_customer_staging" {
  name                = "pp-customerSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_customer_production" {
  name                = "pp-customerProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}


#Definimos el app service Order

resource "azurerm_app_service" "app_service_order_staging" {
  name                = "pp-orderSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_order_production" {
  name                = "pp-orderProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos el app service Alquiler

resource "azurerm_app_service" "app_service_alquiler_staging" {
  name                = "pp-alquilerSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_alquiler_production" {
  name                = "pp-alquilerProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos el app service GateWay.Tienda

resource "azurerm_app_service" "app_service_gatewaytienda_staging" {
  name                = "pp-gatewayTiendaSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_gatewaytienda_production" {
  name                = "pp-gatewayTiendaProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos el app service GateWay.Reservas

resource "azurerm_app_service" "app_service_gatewayreservas_staging" {
  name                = "pp-gatewayReservasSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_gatewayreservas_production" {
  name                = "pp-gatewayReservasProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos el app service WebClient

resource "azurerm_app_service" "app_service_client_staging" {
  name                = "pp-webClientSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_client_production" {
  name                = "pp-webClientProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos el app service Authentication

resource "azurerm_app_service" "app_service_authentication_staging" {
  name                = "pp-clientAuthenticationSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Sta.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Development"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

resource "azurerm_app_service" "app_service_authentication_production" {
  name                = "pp-clientAuthenticationProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  app_service_plan_id = azurerm_app_service_plan.PlayPadelASP-Prod.id


  app_settings = {
    "ASPNETCORE_ENVIRONMENT"= "Production"
  }
  connection_string {
    name  = "Database"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_sql_server.sqlserver.fully_qualified_domain_name Database=azurerm_sql_database.sqldatabase.name;User ID=azurerm_sql_server.sqlserver.administrator_login;Password=azurerm_sql_server.sqlserver.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }

}

#Definimos la cola de Azure Service Bus 

resource "azurerm_servicebus_namespace" "service_bus_staging" {
  name                = "playpadel-servicebus-namespaceSta"
  location            = azurerm_resource_group.PlayPadel-Sta.location
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  sku                 = "Basic"

  tags = {
    source = "terraform"
  }
}

resource "azurerm_servicebus_topic" "example" {
  name                = "order-stock-update"
  resource_group_name = azurerm_resource_group.PlayPadel-Sta.name
  namespace_name      = azurerm_servicebus_namespace.service_bus_staging.name

  enable_partitioning = true
}

resource "azurerm_servicebus_namespace" "service_bus_production" {
  name                = "playpadel-servicebus-namespaceProd"
  location            = azurerm_resource_group.PlayPadel-Prod.location
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  sku                 = "Basic"

  tags = {
    source = "terraform"
  }
}

resource "azurerm_servicebus_topic" "example" {
  name                = "order-stock-update"
  resource_group_name = azurerm_resource_group.PlayPadel-Prod.name
  namespace_name      = azurerm_servicebus_namespace.service_bus_production.name

  enable_partitioning = true
}
