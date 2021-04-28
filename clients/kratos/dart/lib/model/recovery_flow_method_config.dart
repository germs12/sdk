//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//
// @dart=2.0

// ignore_for_file: unused_element, unused_import
// ignore_for_file: always_put_required_named_parameters_first
// ignore_for_file: lines_longer_than_80_chars

part of openapi.api;

class RecoveryFlowMethodConfig {
  /// Returns a new [RecoveryFlowMethodConfig] instance.
  RecoveryFlowMethodConfig({
    @required this.action,
    this.fields = const [],
    this.messages = const [],
    @required this.method,
  });

  /// Action should be used as the form action URL `<form action=\"{{ .Action }}\" method=\"post\">`.
  String action;

  /// Fields contains multiple fields
  List<FormField> fields;

  List<Message> messages;

  /// Method is the form method (e.g. POST)
  String method;

  @override
  bool operator ==(Object other) => identical(this, other) || other is RecoveryFlowMethodConfig &&
     other.action == action &&
     other.fields == fields &&
     other.messages == messages &&
     other.method == method;

  @override
  int get hashCode =>
    (action == null ? 0 : action.hashCode) +
    (fields == null ? 0 : fields.hashCode) +
    (messages == null ? 0 : messages.hashCode) +
    (method == null ? 0 : method.hashCode);

  @override
  String toString() => 'RecoveryFlowMethodConfig[action=$action, fields=$fields, messages=$messages, method=$method]';

  Map<String, dynamic> toJson() {
    final json = <String, dynamic>{};
    if (action != null) {
      json[r'action'] = action;
    }
    if (fields != null) {
      json[r'fields'] = fields;
    }
    if (messages != null) {
      json[r'messages'] = messages;
    }
    if (method != null) {
      json[r'method'] = method;
    }
    return json;
  }

  /// Returns a new [RecoveryFlowMethodConfig] instance and imports its values from
  /// [json] if it's non-null, null if [json] is null.
  static RecoveryFlowMethodConfig fromJson(Map<String, dynamic> json) => json == null
    ? null
    : RecoveryFlowMethodConfig(
        action: json[r'action'],
        fields: FormField.listFromJson(json[r'fields']),
        messages: Message.listFromJson(json[r'messages']),
        method: json[r'method'],
    );

  static List<RecoveryFlowMethodConfig> listFromJson(List<dynamic> json, {bool emptyIsNull, bool growable,}) =>
    json == null || json.isEmpty
      ? true == emptyIsNull ? null : <RecoveryFlowMethodConfig>[]
      : json.map((v) => RecoveryFlowMethodConfig.fromJson(v)).toList(growable: true == growable);

  static Map<String, RecoveryFlowMethodConfig> mapFromJson(Map<String, dynamic> json) {
    final map = <String, RecoveryFlowMethodConfig>{};
    if (json != null && json.isNotEmpty) {
      json.forEach((String key, dynamic v) => map[key] = RecoveryFlowMethodConfig.fromJson(v));
    }
    return map;
  }

  // maps a json object with a list of RecoveryFlowMethodConfig-objects as value to a dart map
  static Map<String, List<RecoveryFlowMethodConfig>> mapListFromJson(Map<String, dynamic> json, {bool emptyIsNull, bool growable,}) {
    final map = <String, List<RecoveryFlowMethodConfig>>{};
    if (json != null && json.isNotEmpty) {
      json.forEach((String key, dynamic v) {
        map[key] = RecoveryFlowMethodConfig.listFromJson(v, emptyIsNull: emptyIsNull, growable: growable);
      });
    }
    return map;
  }
}
