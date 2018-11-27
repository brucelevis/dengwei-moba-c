# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: RoomProto.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf.internal import enum_type_wrapper
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
from google.protobuf import descriptor_pb2
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='RoomProto.proto',
  package='Google.Protobuf',
  syntax='proto3',
  serialized_pb=_b('\n\x0fRoomProto.proto\x12\x0fGoogle.Protobuf\"9\n\x10PB_C2SLoginHello\x12\x13\n\x0b\x66ightroomid\x18\x01 \x01(\r\x12\x10\n\x08hellokey\x18\x02 \x01(\t\"=\n\rPB_PlayerInfo\x12\x0b\n\x03pid\x18\x01 \x01(\x04\x12\x11\n\tplayeridx\x18\x02 \x01(\x05\x12\x0c\n\x04name\x18\x03 \x01(\t\"\x17\n\x15PB_C2SFightLoadingEnd\"\x12\n\x10PB_S2CFightStart\"\x11\n\x0fPB_C2SFightSOut\"\x1f\n\x0fPB_LoadingAgain\x12\x0c\n\x04type\x18\x01 \x01(\r\"4\n\x0fPB_C2SFightSEnd\x12\r\n\x05iswin\x18\x01 \x01(\x08\x12\x12\n\nresultflag\x18\x02 \x01(\r\"\x1e\n\x0fPB_S2CFightSEnd\x12\x0b\n\x03\x65xp\x18\x01 \x01(\r\"\x8c\x01\n\x0ePB_ClientInput\x12-\n\tInputType\x18\x01 \x01(\x0e\x32\x1a.Google.Protobuf.InputType\x12\x0f\n\x07\x41ngle_X\x18\x02 \x01(\x05\x12\x0f\n\x07\x41ngle_Y\x18\x03 \x01(\x05\x12\x0b\n\x03Key\x18\x04 \x01(\x05\x12\r\n\x05Pos_X\x18\x05 \x01(\x05\x12\r\n\x05Pos_Y\x18\x06 \x01(\x05\"D\n\x11PB_C2SClientInput\x12/\n\x06inputs\x18\x01 \x03(\x0b\x32\x1f.Google.Protobuf.PB_ClientInput\"O\n\x0ePB_PlayerFrame\x12\r\n\x05index\x18\x01 \x01(\r\x12.\n\x05input\x18\x02 \x01(\x0b\x32\x1f.Google.Protobuf.PB_ClientInput\"T\n\x0cPB_FrameInfo\x12\x13\n\x0b\x66rame_index\x18\x01 \x01(\r\x12/\n\x06inputs\x18\x02 \x03(\x0b\x32\x1f.Google.Protobuf.PB_PlayerFrame*\x9d\x01\n\x10LoadingAgainType\x12\x19\n\x15LoadingAgainType_NONE\x10\x00\x12\x1b\n\x17\x43\x32S_LOADING_AGAIN_START\x10\x01\x12\x1b\n\x17S2C_LOADING_AGAIN_START\x10\x02\x12\x19\n\x15\x43\x32S_LOADING_AGAIN_END\x10\x03\x12\x19\n\x15S2C_LOADING_AGAIN_END\x10\x04*\x84\x02\n\tInputType\x12\x12\n\x0eInputType_NONE\x10\x00\x12\x18\n\x14InputType_MOVE_START\x10\x01\x12\x18\n\x14InputType_MOVE_ANGLE\x10\x02\x12\x16\n\x12InputType_MOVE_END\x10\x03\x12\x16\n\x12InputType_KEY_DOWN\x10\x04\x12\x14\n\x10InputType_KEY_UP\x10\x05\x12\x1c\n\x18InputType_KEY_LONG_START\x10\x06\x12\x1a\n\x16InputType_KEY_LONG_END\x10\x07\x12\x17\n\x13InputType_KEY_ANGLE\x10\x08\x12\x16\n\x12InputType_CLICK_XY\x10\tb\x06proto3')
)

_LOADINGAGAINTYPE = _descriptor.EnumDescriptor(
  name='LoadingAgainType',
  full_name='Google.Protobuf.LoadingAgainType',
  filename=None,
  file=DESCRIPTOR,
  values=[
    _descriptor.EnumValueDescriptor(
      name='LoadingAgainType_NONE', index=0, number=0,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='C2S_LOADING_AGAIN_START', index=1, number=1,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='S2C_LOADING_AGAIN_START', index=2, number=2,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='C2S_LOADING_AGAIN_END', index=3, number=3,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='S2C_LOADING_AGAIN_END', index=4, number=4,
      options=None,
      type=None),
  ],
  containing_type=None,
  options=None,
  serialized_start=722,
  serialized_end=879,
)
_sym_db.RegisterEnumDescriptor(_LOADINGAGAINTYPE)

LoadingAgainType = enum_type_wrapper.EnumTypeWrapper(_LOADINGAGAINTYPE)
_INPUTTYPE = _descriptor.EnumDescriptor(
  name='InputType',
  full_name='Google.Protobuf.InputType',
  filename=None,
  file=DESCRIPTOR,
  values=[
    _descriptor.EnumValueDescriptor(
      name='InputType_NONE', index=0, number=0,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_MOVE_START', index=1, number=1,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_MOVE_ANGLE', index=2, number=2,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_MOVE_END', index=3, number=3,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_KEY_DOWN', index=4, number=4,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_KEY_UP', index=5, number=5,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_KEY_LONG_START', index=6, number=6,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_KEY_LONG_END', index=7, number=7,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_KEY_ANGLE', index=8, number=8,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='InputType_CLICK_XY', index=9, number=9,
      options=None,
      type=None),
  ],
  containing_type=None,
  options=None,
  serialized_start=882,
  serialized_end=1142,
)
_sym_db.RegisterEnumDescriptor(_INPUTTYPE)

InputType = enum_type_wrapper.EnumTypeWrapper(_INPUTTYPE)
LoadingAgainType_NONE = 0
C2S_LOADING_AGAIN_START = 1
S2C_LOADING_AGAIN_START = 2
C2S_LOADING_AGAIN_END = 3
S2C_LOADING_AGAIN_END = 4
InputType_NONE = 0
InputType_MOVE_START = 1
InputType_MOVE_ANGLE = 2
InputType_MOVE_END = 3
InputType_KEY_DOWN = 4
InputType_KEY_UP = 5
InputType_KEY_LONG_START = 6
InputType_KEY_LONG_END = 7
InputType_KEY_ANGLE = 8
InputType_CLICK_XY = 9



_PB_C2SLOGINHELLO = _descriptor.Descriptor(
  name='PB_C2SLoginHello',
  full_name='Google.Protobuf.PB_C2SLoginHello',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='fightroomid', full_name='Google.Protobuf.PB_C2SLoginHello.fightroomid', index=0,
      number=1, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='hellokey', full_name='Google.Protobuf.PB_C2SLoginHello.hellokey', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=36,
  serialized_end=93,
)


_PB_PLAYERINFO = _descriptor.Descriptor(
  name='PB_PlayerInfo',
  full_name='Google.Protobuf.PB_PlayerInfo',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='pid', full_name='Google.Protobuf.PB_PlayerInfo.pid', index=0,
      number=1, type=4, cpp_type=4, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='playeridx', full_name='Google.Protobuf.PB_PlayerInfo.playeridx', index=1,
      number=2, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='name', full_name='Google.Protobuf.PB_PlayerInfo.name', index=2,
      number=3, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=95,
  serialized_end=156,
)


_PB_C2SFIGHTLOADINGEND = _descriptor.Descriptor(
  name='PB_C2SFightLoadingEnd',
  full_name='Google.Protobuf.PB_C2SFightLoadingEnd',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=158,
  serialized_end=181,
)


_PB_S2CFIGHTSTART = _descriptor.Descriptor(
  name='PB_S2CFightStart',
  full_name='Google.Protobuf.PB_S2CFightStart',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=183,
  serialized_end=201,
)


_PB_C2SFIGHTSOUT = _descriptor.Descriptor(
  name='PB_C2SFightSOut',
  full_name='Google.Protobuf.PB_C2SFightSOut',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=203,
  serialized_end=220,
)


_PB_LOADINGAGAIN = _descriptor.Descriptor(
  name='PB_LoadingAgain',
  full_name='Google.Protobuf.PB_LoadingAgain',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='type', full_name='Google.Protobuf.PB_LoadingAgain.type', index=0,
      number=1, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=222,
  serialized_end=253,
)


_PB_C2SFIGHTSEND = _descriptor.Descriptor(
  name='PB_C2SFightSEnd',
  full_name='Google.Protobuf.PB_C2SFightSEnd',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='iswin', full_name='Google.Protobuf.PB_C2SFightSEnd.iswin', index=0,
      number=1, type=8, cpp_type=7, label=1,
      has_default_value=False, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='resultflag', full_name='Google.Protobuf.PB_C2SFightSEnd.resultflag', index=1,
      number=2, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=255,
  serialized_end=307,
)


_PB_S2CFIGHTSEND = _descriptor.Descriptor(
  name='PB_S2CFightSEnd',
  full_name='Google.Protobuf.PB_S2CFightSEnd',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='exp', full_name='Google.Protobuf.PB_S2CFightSEnd.exp', index=0,
      number=1, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=309,
  serialized_end=339,
)


_PB_CLIENTINPUT = _descriptor.Descriptor(
  name='PB_ClientInput',
  full_name='Google.Protobuf.PB_ClientInput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='InputType', full_name='Google.Protobuf.PB_ClientInput.InputType', index=0,
      number=1, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='Angle_X', full_name='Google.Protobuf.PB_ClientInput.Angle_X', index=1,
      number=2, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='Angle_Y', full_name='Google.Protobuf.PB_ClientInput.Angle_Y', index=2,
      number=3, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='Key', full_name='Google.Protobuf.PB_ClientInput.Key', index=3,
      number=4, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='Pos_X', full_name='Google.Protobuf.PB_ClientInput.Pos_X', index=4,
      number=5, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='Pos_Y', full_name='Google.Protobuf.PB_ClientInput.Pos_Y', index=5,
      number=6, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=342,
  serialized_end=482,
)


_PB_C2SCLIENTINPUT = _descriptor.Descriptor(
  name='PB_C2SClientInput',
  full_name='Google.Protobuf.PB_C2SClientInput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='inputs', full_name='Google.Protobuf.PB_C2SClientInput.inputs', index=0,
      number=1, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=484,
  serialized_end=552,
)


_PB_PLAYERFRAME = _descriptor.Descriptor(
  name='PB_PlayerFrame',
  full_name='Google.Protobuf.PB_PlayerFrame',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='index', full_name='Google.Protobuf.PB_PlayerFrame.index', index=0,
      number=1, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='input', full_name='Google.Protobuf.PB_PlayerFrame.input', index=1,
      number=2, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=554,
  serialized_end=633,
)


_PB_FRAMEINFO = _descriptor.Descriptor(
  name='PB_FrameInfo',
  full_name='Google.Protobuf.PB_FrameInfo',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='frame_index', full_name='Google.Protobuf.PB_FrameInfo.frame_index', index=0,
      number=1, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='inputs', full_name='Google.Protobuf.PB_FrameInfo.inputs', index=1,
      number=2, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=635,
  serialized_end=719,
)

_PB_CLIENTINPUT.fields_by_name['InputType'].enum_type = _INPUTTYPE
_PB_C2SCLIENTINPUT.fields_by_name['inputs'].message_type = _PB_CLIENTINPUT
_PB_PLAYERFRAME.fields_by_name['input'].message_type = _PB_CLIENTINPUT
_PB_FRAMEINFO.fields_by_name['inputs'].message_type = _PB_PLAYERFRAME
DESCRIPTOR.message_types_by_name['PB_C2SLoginHello'] = _PB_C2SLOGINHELLO
DESCRIPTOR.message_types_by_name['PB_PlayerInfo'] = _PB_PLAYERINFO
DESCRIPTOR.message_types_by_name['PB_C2SFightLoadingEnd'] = _PB_C2SFIGHTLOADINGEND
DESCRIPTOR.message_types_by_name['PB_S2CFightStart'] = _PB_S2CFIGHTSTART
DESCRIPTOR.message_types_by_name['PB_C2SFightSOut'] = _PB_C2SFIGHTSOUT
DESCRIPTOR.message_types_by_name['PB_LoadingAgain'] = _PB_LOADINGAGAIN
DESCRIPTOR.message_types_by_name['PB_C2SFightSEnd'] = _PB_C2SFIGHTSEND
DESCRIPTOR.message_types_by_name['PB_S2CFightSEnd'] = _PB_S2CFIGHTSEND
DESCRIPTOR.message_types_by_name['PB_ClientInput'] = _PB_CLIENTINPUT
DESCRIPTOR.message_types_by_name['PB_C2SClientInput'] = _PB_C2SCLIENTINPUT
DESCRIPTOR.message_types_by_name['PB_PlayerFrame'] = _PB_PLAYERFRAME
DESCRIPTOR.message_types_by_name['PB_FrameInfo'] = _PB_FRAMEINFO
DESCRIPTOR.enum_types_by_name['LoadingAgainType'] = _LOADINGAGAINTYPE
DESCRIPTOR.enum_types_by_name['InputType'] = _INPUTTYPE
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

PB_C2SLoginHello = _reflection.GeneratedProtocolMessageType('PB_C2SLoginHello', (_message.Message,), dict(
  DESCRIPTOR = _PB_C2SLOGINHELLO,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_C2SLoginHello)
  ))
_sym_db.RegisterMessage(PB_C2SLoginHello)

PB_PlayerInfo = _reflection.GeneratedProtocolMessageType('PB_PlayerInfo', (_message.Message,), dict(
  DESCRIPTOR = _PB_PLAYERINFO,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_PlayerInfo)
  ))
_sym_db.RegisterMessage(PB_PlayerInfo)

PB_C2SFightLoadingEnd = _reflection.GeneratedProtocolMessageType('PB_C2SFightLoadingEnd', (_message.Message,), dict(
  DESCRIPTOR = _PB_C2SFIGHTLOADINGEND,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_C2SFightLoadingEnd)
  ))
_sym_db.RegisterMessage(PB_C2SFightLoadingEnd)

PB_S2CFightStart = _reflection.GeneratedProtocolMessageType('PB_S2CFightStart', (_message.Message,), dict(
  DESCRIPTOR = _PB_S2CFIGHTSTART,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_S2CFightStart)
  ))
_sym_db.RegisterMessage(PB_S2CFightStart)

PB_C2SFightSOut = _reflection.GeneratedProtocolMessageType('PB_C2SFightSOut', (_message.Message,), dict(
  DESCRIPTOR = _PB_C2SFIGHTSOUT,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_C2SFightSOut)
  ))
_sym_db.RegisterMessage(PB_C2SFightSOut)

PB_LoadingAgain = _reflection.GeneratedProtocolMessageType('PB_LoadingAgain', (_message.Message,), dict(
  DESCRIPTOR = _PB_LOADINGAGAIN,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_LoadingAgain)
  ))
_sym_db.RegisterMessage(PB_LoadingAgain)

PB_C2SFightSEnd = _reflection.GeneratedProtocolMessageType('PB_C2SFightSEnd', (_message.Message,), dict(
  DESCRIPTOR = _PB_C2SFIGHTSEND,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_C2SFightSEnd)
  ))
_sym_db.RegisterMessage(PB_C2SFightSEnd)

PB_S2CFightSEnd = _reflection.GeneratedProtocolMessageType('PB_S2CFightSEnd', (_message.Message,), dict(
  DESCRIPTOR = _PB_S2CFIGHTSEND,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_S2CFightSEnd)
  ))
_sym_db.RegisterMessage(PB_S2CFightSEnd)

PB_ClientInput = _reflection.GeneratedProtocolMessageType('PB_ClientInput', (_message.Message,), dict(
  DESCRIPTOR = _PB_CLIENTINPUT,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_ClientInput)
  ))
_sym_db.RegisterMessage(PB_ClientInput)

PB_C2SClientInput = _reflection.GeneratedProtocolMessageType('PB_C2SClientInput', (_message.Message,), dict(
  DESCRIPTOR = _PB_C2SCLIENTINPUT,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_C2SClientInput)
  ))
_sym_db.RegisterMessage(PB_C2SClientInput)

PB_PlayerFrame = _reflection.GeneratedProtocolMessageType('PB_PlayerFrame', (_message.Message,), dict(
  DESCRIPTOR = _PB_PLAYERFRAME,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_PlayerFrame)
  ))
_sym_db.RegisterMessage(PB_PlayerFrame)

PB_FrameInfo = _reflection.GeneratedProtocolMessageType('PB_FrameInfo', (_message.Message,), dict(
  DESCRIPTOR = _PB_FRAMEINFO,
  __module__ = 'RoomProto_pb2'
  # @@protoc_insertion_point(class_scope:Google.Protobuf.PB_FrameInfo)
  ))
_sym_db.RegisterMessage(PB_FrameInfo)


# @@protoc_insertion_point(module_scope)
