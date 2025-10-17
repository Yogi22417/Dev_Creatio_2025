define("Accounts_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "AnnualRevenue"
			},
			{
				"operation": "remove",
				"name": "EmployeesNumber"
			},
			{
				"operation": "merge",
				"name": "Timeline",
				"values": {
					"filterValues": "$Timeline_AllTileFilters"
				}
			},
			{
				"operation": "merge",
				"name": "TimelineTile_Email",
				"values": {
					"filters": "$TimelineTile_Email_Items"
				}
			},
			{
				"operation": "merge",
				"name": "TimelineTile_Task",
				"values": {
					"filters": "$TimelineTile_Task_Items"
				}
			},
			{
				"operation": "merge",
				"name": "TimelineTile_Call",
				"values": {
					"filters": "$TimelineTile_Call_Items"
				}
			},
			{
				"operation": "insert",
				"name": "RegistrationNumber",
				"values": {
					"layoutConfig": {
						"column": 1,
						"colSpan": 1,
						"row": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"label": "$Resources.Strings.PDS_UsrRegistrationNumber_olajv5u",
					"labelPosition": "auto",
					"control": "$PDS_UsrRegistrationNumber_olajv5u",
					"multiline": false
				},
				"parentName": "AccountInfoFieldsContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ComboBox_n4cmk65",
				"values": {
					"layoutConfig": {
						"column": 2,
						"colSpan": 1,
						"row": 2,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.PDS_EmployeesNumber_fktcq3k",
					"labelPosition": "auto",
					"control": "$PDS_EmployeesNumber_fktcq3k",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "AccountInfoFieldsContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "addRecord_2yptax3",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_2yptax3_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "ComboBox_n4cmk65",
				"propertyName": "listActions",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"PDS_UsrRegistrationNumber_olajv5u": {
						"modelConfig": {
							"path": "PDS.UsrRegistrationNumber"
						}
					},
					"Timeline_AllTileFilters": {
						"from": [],
						"converter": "crt.ToTileFilterGroup"
					},
					"PDS_EmployeesNumber_fktcq3k": {
						"modelConfig": {
							"path": "PDS.EmployeesNumber"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"TimelineTile_EmailDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "Activity"
						}
					},
					"TimelineTile_TaskDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "Activity"
						}
					},
					"TimelineTile_CallDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "Call"
						}
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});