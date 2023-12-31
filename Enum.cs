﻿public enum ENUM_LIBWFX_ERRCODE
{
    LIBWFX_ERRCODE_SUCCESS = 0,
    LIBWFX_ERRCODE_FAIL,
    LIBWFX_ERRCODE_NO_INIT,
    LIBWFX_ERRCODE_NO_RECOGNIZE_TOOL,
    LIBWFX_ERRCODE_NO_DEVICES,
    LIBWFX_ERRCODE_FORMAT_ERROR,
    LIBWFX_ERRCODE_NO_DEVICE_NAME,
    LIBWFX_ERRCODE_NO_SOURCE,
    LIBWFX_ERRCODE_FILE_NO_EXIST,
    LIBWFX_ERRCODE_PAPER_NOT_READY,
    LIBWFX_ERRCODE_INVALID_SERIALNUM,
}

public enum ENUM_LIBWFX_EVENT_CODE
{
    LIBWFX_EVENT_PAPER_DETECTED = 0,
    LIBWFX_EVENT_NO_PAPER,
    LIBWFX_EVENT_PAPER_JAM,
    LIBWFX_EVENT_MULTIFEED,
    LIBWFX_EVENT_NO_CALIBRATION_DATA,
    LIBWFX_EVENT_WARMUP_COUNTDOWN,
}

public enum ENUM_LIBWFX_EXCEPTION_CODE
{
    LIBWFX_EXC_OTHER = 0,
    LIBWFX_EXC_TIFF_SAVE_FINSIHED,
    LIBWFX_EXC_PDF_SAVE_FINSIHED,
}

public enum ENUM_LIBWFX_NOTIFY_CODE
{
    LIBWFX_NOTIFY_IMAGE_DONE = 0,
    LIBWFX_NOTIFY_END,
    LIBWFX_NOTIFY_EXCEPTION,
}
