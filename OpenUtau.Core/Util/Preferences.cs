﻿<ResourceDictionary xmlns="https://github.com/avaloniaui"
                    xmlns:system="clr-namespace:System;assembly=mscorlib"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

  <system:String x:Key="context.note.copy">Copy note</system:String>
  <system:String x:Key="context.note.delete">Delete note</system:String>
  <system:String x:Key="context.note.pasteparameters">Select and paste parameters</system:String>
  <system:String x:Key="context.part.delete">Delete part</system:String>
  <system:String x:Key="context.part.gotofile">View file location</system:String>
  <system:String x:Key="context.part.rename">Rename part</system:String>
  <system:String x:Key="context.part.replaceaudio">Reselect audio file</system:String>
  <system:String x:Key="context.part.transcribe">Transcribe audio to create a note part</system:String>
  <system:String x:Key="context.part.transcribing">Transcribing</system:String>
  <system:String x:Key="context.pitch.easein">Ease in</system:String>
  <system:String x:Key="context.pitch.easeinout">Ease in/out</system:String>
  <system:String x:Key="context.pitch.easeout">Ease out</system:String>
  <system:String x:Key="context.pitch.linear">Linear</system:String>
  <system:String x:Key="context.pitch.pointadd">Add point</system:String>
  <system:String x:Key="context.pitch.pointdel">Delete point</system:String>
  <system:String x:Key="context.pitch.pointsnapprev">Snap to previous note</system:String>
  <system:String x:Key="context.timeline.addtempo">Add tempo change at {0}</system:String>
  <system:String x:Key="context.timeline.addtimesig">Add time signature change</system:String>
  <system:String x:Key="context.timeline.deltempo">Delete tempo change at {0}</system:String>
  <system:String x:Key="context.timeline.deltimesig">Delete time signature change</system:String>

  <system:String x:Key="debug.clear">Clear</system:String>
  <system:String x:Key="debug.copylog">Copy Log</system:String>
  <system:String x:Key="debug.reverselogorder">Reverse Log Order</system:String>

  <system:String x:Key="dialogs.about.caption">About OpenUTAU</system:String>
  <system:String x:Key="dialogs.about.message">
    OpenUtau aims to be an open source editing environment for UTAU community, with a modern user experience and intelligent phonological support. Visit us on Github.
  </system:String>
  <system:String x:Key="dialogs.exitsave.caption">Exit OpenUtau</system:String>
  <system:String x:Key="dialogs.exitsave.message">The current project contains unsaved changes. Do you want to save it?</system:String>
  <system:String x:Key="dialogs.export.caption">Export</system:String>
  <system:String x:Key="dialogs.export.savefirst">Save project file first</system:String>
  <system:String x:Key="dialogs.importtracks.caption">Import tracks</system:String>
  <system:String x:Key="dialogs.importtracks.importtempo">The imported project contains the following tempo markers. Do you want to use them?</system:String>
  <system:String x:Key="dialogs.installdependency.caption">Installing dependency</system:String>
  <system:String x:Key="dialogs.installdependency.message">Installing </system:String>
  <system:String x:Key="dialogs.installdll.caption">Installing phonemizer</system:String>
  <system:String x:Key="dialogs.installdll.message">Installing </system:String>
  <system:String x:Key="dialogs.messagebox.cancel">Cancel</system:String>
  <system:String x:Key="dialogs.messagebox.copy">Copy error to clipboard</system:String>
  <system:String x:Key="dialogs.messagebox.no">No</system:String>
  <system:String x:Key="dialogs.messagebox.ok">Ok</system:String>
  <system:String x:Key="dialogs.messagebox.yes">Yes</system:String>
  <system:String x:Key="dialogs.noresampler.caption">No resampler</system:String>
  <system:String x:Key="dialogs.noresampler.message">No resampler! Put your favourite resampler exe or dll in the Resamplers folder and choose it in Preferences!</system:String>
  <system:String x:Key="dialogs.remaptimeaxis.message">This tool will change the tempo of the project without changing the actual positions and durations (in seconds) of notes.
  New BPM:</system:String>
  <system:String x:Key="dialogs.timesig.caption">Time Signature</system:String>
  <system:String x:Key="dialogs.tracksettings.caption">Track Settings</system:String>
  <system:String x:Key="dialogs.tracksettings.location">Location</system:String>
  <system:String x:Key="dialogs.tracksettings.renderer">Renderer</system:String>
  <system:String x:Key="dialogs.tracksettings.setasdefault">Set As Default</system:String>
  <system:String x:Key="dialogs.unsupportedfile.caption">Unsupported file format</system:String>
  <system:String x:Key="dialogs.unsupportedfile.message">Unsupported file format: </system:String>
  <system:String x:Key="dialogs.voicecolorremapping">Voice color remapping</system:String>
  <system:String x:Key="dialogs.voicecolorremapping.caption">Applies to all notes in this track:</system:String>

  <system:String x:Key="errors.caption">Error</system:String>
  <system:String x:Key="errors.details">Error Details</system:String>
  <system:String x:Key="errors.diffsinger.downloadvocoder1">Error loading vocoder </system:String>
  <system:String x:Key="errors.diffsinger.downloadvocoder2">. Please download vocoder from </system:String>
  <system:String x:Key="errors.encryptedarchive">Encrypted archive file isn't supported. Please extract the archive file manually.</system:String>
  <system:String x:Key="errors.expression.abbrlong">Abbreviation must be between 1 and 4 characters long</system:String>
  <system:String x:Key="errors.expression.abbrset">Abbreviation must be set</system:String>
  <system:String x:Key="errors.expression.abbrunique">Abbreviations must be unique</system:String>
  <system:String x:Key="errors.expression.default">Default value must be between min and max</system:String>
  <system:String x:Key="errors.expression.flagunique">Flags must be unique</system:String>
  <system:String x:Key="errors.expression.marge">The following expressions have been merged due to duplicate flags</system:String>
  <system:String x:Key="errors.expression.min">Min must be smaller than max</system:String>
  <system:String x:Key="errors.expression.name">Name must be set</system:String>
  <system:String x:Key="errors.failed.export">Failed to export</system:String>
  <system:String x:Key="errors.failed.importaudio">Failed to import audio</system:String>
  <system:String x:Key="errors.failed.importfiles">Failed to import files</system:String>
  <system:String x:Key="errors.failed.importmidi">Failed to import midi</system:String>
  <system:String x:Key="errors.failed.installsinger">Failed to install singer</system:String>
  <system:String x:Key="errors.failed.load">Failed to load</system:String>
  <system:String x:Key="errors.failed.loadprefs">Failed to load prefs. Initialize it.</system:String>
  <system:String x:Key="errors.failed.openfile">Failed to open</system:String>
  <system:String x:Key="errors.failed.openlocation">Failed to open location</system:String>
  <system:String x:Key="errors.failed.render">Failed to render</system:String>
  <system:String x:Key="errors.failed.runeditingmacro">Failed to run editing macro</system:String>
  <system:String x:Key="errors.failed.save">Failed to save</system:String>
  <system:String x:Key="errors.failed.savesingerconfig">Failed to save singer config file</system:String>
  <system:String x:Key="errors.failed.searchsinger">Failed to search singers</system:String>
  <system:String x:Key="errors.install.cpp">Try installing the latest Visual C++ Redistributable. https://learn.microsoft.com/en-US/cpp/windows/latest-supported-vc-redist?view=msvc-170</system:String>
  <system:String x:Key="errors.lyrics.regex">Character not allowed in regular expression</system:String>
  <system:String x:Key="errors.lyrics.regexpreview">- regular expression error -</system:String>

  <system:String x:Key="exps.abbr">Abbreviation</system:String>
  <system:String x:Key="exps.apply">Apply</system:String>
  <system:String x:Key="exps.caption">Expressions</system:String>
  <system:String x:Key="exps.defaultvalue">Default</system:String>
  <system:String x:Key="exps.flag">Resampler Flag</system:String>
  <system:String x:Key="exps.getsuggestions">Add all expressions suggested by renderers</system:String>
  <system:String x:Key="exps.isflag">Is Resampler Flag</system:String>
  <system:String x:Key="exps.maxvalue">Max</system:String>
  <system:String x:Key="exps.minvalue">Min</system:String>
  <system:String x:Key="exps.name">Name</system:String>
  <system:String x:Key="exps.optionvalues">Option Values</system:String>
  <system:String x:Key="exps.sepbycomma">Separate values by ','</system:String>
  <system:String x:Key="exps.type">Type</system:String>
  <system:String x:Key="exps.type.curve">Curve</system:String>
  <system:String x:Key="exps.type.numerical">Numerical</system:String>
  <system:String x:Key="exps.type.options">Options</system:String>

  <system:String x:Key="languages.de">German</system:String>
  <system:String x:Key="languages.en">English</system:String>
  <system:String x:Key="languages.es">Spanish</system:String>
  <system:String x:Key="languages.fr">French</system:String>
  <system:String x:Key="languages.invariant">Not translating</system:String>
  <system:String x:Key="languages.it">Italian</system:String>
  <system:String x:Key="languages.ja">Japanese</system:String>
  <system:String x:Key="languages.ko">Korean</system:String>
  <system:String x:Key="languages.pl">Polish</system:String>
  <system:String x:Key="languages.pt">Portuguese</system:String>
  <system:String x:Key="languages.ru">Russian</system:String>
  <system:String x:Key="languages.vi">Vietnamese</system:String>
  <system:String x:Key="languages.zh">Chinese</system:String>
  <system:String x:Key="languages.zh-yue">Cantonese</system:String>
  <system:String x:Key="languages.th">Thai</system:String>

  <system:String x:Key="lyrics.apply">Apply</system:String>
  <system:String x:Key="lyrics.cancel">Cancel</system:String>
  <system:String x:Key="lyrics.caption">Edit Lyrics</system:String>
  <system:String x:Key="lyrics.livepreview">Live preview</system:String>
  <system:String x:Key="lyrics.max">Max</system:String>
  <system:String x:Key="lyrics.reset">Reset</system:String>
  <system:String x:Key="lyrics.selectnotes">Select some notes first!</system:String>
  <system:String x:Key="lyrics.separators">Separators</system:String>

  <system:String x:Key="lyricsreplace.after">After :</system:String>
  <system:String x:Key="lyricsreplace.before">Before :</system:String>
  <system:String x:Key="lyricsreplace.preset.rmvalphabet">Remove alphabet</system:String>
  <system:String x:Key="lyricsreplace.preset.rmvnonhiragana">Remove non-hiragana</system:String>
  <system:String x:Key="lyricsreplace.preset.rmvphonetichint">Remove phonetic hint</system:String>
  <system:String x:Key="lyricsreplace.preset.rmvspace">Remove spaces and earlier</system:String>
  <system:String x:Key="lyricsreplace.preset.rmvtone">Remove tone suffix</system:String>
  <system:String x:Key="lyricsreplace.presets">Presets</system:String>
  <system:String x:Key="lyricsreplace.preview">Preview</system:String>
  <system:String x:Key="lyricsreplace.regex">Regular expressions can be used</system:String>
  <system:String x:Key="lyricsreplace.replace">General lyrics replacement</system:String>

  <system:String x:Key="menu.edit">Edit</system:String>
  <system:String x:Key="menu.edit.copy">Copy</system:String>
  <system:String x:Key="menu.edit.cut">Cut</system:String>
  <system:String x:Key="menu.edit.delete">Delete</system:String>
  <system:String x:Key="menu.edit.lockunselectednotes">Lock editing of unselected notes</system:String>
  <system:String x:Key="menu.edit.lockunselectednotes.expressions">Expressions</system:String>
  <system:String x:Key="menu.edit.lockunselectednotes.pitchpoints">Pitch Points</system:String>
  <system:String x:Key="menu.edit.lockunselectednotes.vibrato">Vibrato</system:String>
  <system:String x:Key="menu.edit.paste">Paste</system:String>
  <system:String x:Key="menu.edit.redo">Redo</system:String>
  <system:String x:Key="menu.edit.selectall">Select All</system:String>
  <system:String x:Key="menu.edit.undo">Undo</system:String>
  <system:String x:Key="menu.file">File</system:String>
  <system:String x:Key="menu.file.exit">Exit</system:String>
  <system:String x:Key="menu.file.exportaudio">Export Audio</system:String>
  <system:String x:Key="menu.file.exportds">Export DiffSinger Scripts To</system:String>
  <system:String x:Key="menu.file.exportds.v2">Export DiffSinger Scripts To (v2)</system:String>
  <system:String x:Key="menu.file.exportds.v2withoutpitch">Export DiffSinger Scripts To (v2, without pitch curve)</system:String>
  <system:String x:Key="menu.file.exportmidi">Export Midi File</system:String>
  <system:String x:Key="menu.file.exportmixdown">Mixdown To Wav File</system:String>
  <system:String x:Key="menu.file.exportproject">Export Project</system:String>
  <system:String x:Key="menu.file.exportust">Export Ust Files</system:String>
  <system:String x:Key="menu.file.exportustto">Export Ust Files To...</system:String>
  <system:String x:Key="menu.file.exportwav">Export Wav Files</system:String>
  <system:String x:Key="menu.file.exportwavto">Export Wav Files To...</system:String>
  <system:String x:Key="menu.file.importaudio">Import Audio...</system:String>
  <system:String x:Key="menu.file.importmidi">Import Midi...</system:String>
  <system:String x:Key="menu.file.importmidi.drywetmidi">DryWetMidi Importer</system:String>
  <system:String x:Key="menu.file.importmidi.naudio">Naudio Importer</system:String>
  <system:String x:Key="menu.file.importtracks">Import Tracks...</system:String>
  <system:String x:Key="menu.file.new">New</system:String>
  <system:String x:Key="menu.file.newfromtemplate">New From Template</system:String>
  <system:String x:Key="menu.file.open">Open...</system:String>
  <system:String x:Key="menu.file.openas">Open As</system:String>
  <system:String x:Key="menu.file.openexportlocation">Open Export Location</system:String>
  <system:String x:Key="menu.file.openprojectlocation">Open Project Location</system:String>
  <system:String x:Key="menu.file.openrecent">Open Recent</system:String>
  <system:String x:Key="menu.file.save">Save</system:String>
  <system:String x:Key="menu.file.saveas">Save As...</system:String>
  <system:String x:Key="menu.file.savetemplate">Save Template...</system:String>
  <system:String x:Key="menu.help">Help</system:String>
  <system:String x:Key="menu.help.about">About OpenUtau</system:String>
  <system:String x:Key="menu.help.checkupdate">Check Update</system:String>
  <system:String x:Key="menu.help.logslocation">Open Logs Location</system:String>
  <system:String x:Key="menu.help.reportissue">Report Issue</system:String>
  <system:String x:Key="menu.help.wiki">OpenUtau Documentation</system:String>
  <system:String x:Key="menu.project">Project</system:String>
  <system:String x:Key="menu.project.expressions">Expressions...</system:String>
  <system:String x:Key="menu.project.remaptimeaxis">Adjust Tempo (Preserve Timing)</system:String>
  <system:String x:Key="menu.tools">Tools</system:String>
  <system:String x:Key="menu.tools.clearcache">Clear Cache</system:String>
  <system:String x:Key="menu.tools.debugwindow">Debug Window</system:String>
  <system:String x:Key="menu.tools.dependency.install">Install Dependency (.oudep)...</system:String>
  <system:String x:Key="menu.tools.layout">Layout</system:String>
  <system:String x:Key="menu.tools.layout.hsplit11">Horizontal 1:1</system:String>
  <system:String x:Key="menu.tools.layout.hsplit12">Horizontal 1:2</system:String>
  <system:String x:Key="menu.tools.layout.hsplit13">Horizontal 1:3</system:String>
  <system:String x:Key="menu.tools.layout.vsplit11">Vertical 1:1</system:String>
  <system:String x:Key="menu.tools.layout.vsplit12">Vertical 1:2</system:String>
  <system:String x:Key="menu.tools.layout.vsplit13">Vertical 1:3</system:String>
  <system:String x:Key="menu.tools.prefs">Preferences...</system:String>
  <system:String x:Key="menu.tools.singer.install">Install Singer...</system:String>
  <system:String x:Key="menu.tools.singer.installadv">Install Singer (Advanced)...</system:String>
  <system:String x:Key="menu.tools.singers">Singers...</system:String>
  <system:String x:Key="menu.view">View</system:String>

  <system:String x:Key="notedefaults.lyric">Lyric</system:String>
  <system:String x:Key="notedefaults.lyric.defaultlyric">Default Lyric</system:String>
  <system:String x:Key="notedefaults.portamento">Portamento</system:String>
  <system:String x:Key="notedefaults.portamento.length">Length</system:String>
  <system:String x:Key="notedefaults.portamento.start">Start</system:String>
  <system:String x:Key="notedefaults.preset">Preset</system:String>
  <system:String x:Key="notedefaults.preset.namenew">New Preset Name</system:String>
  <system:String x:Key="notedefaults.preset.remove">Remove</system:String>
  <system:String x:Key="notedefaults.preset.remove.tooltip">Removes last applied preset.</system:String>
  <system:String x:Key="notedefaults.preset.save">Save</system:String>
  <system:String x:Key="notedefaults.preset.save.tooltip">Save current settings to a new preset.</system:String>
  <system:String x:Key="notedefaults.reset">Reset All Settings</system:String>
  <system:String x:Key="notedefaults.reset.tooltip">Reset every setting to default values.
Warning: this option removes custom presets.</system:String>
  <system:String x:Key="notedefaults.vibrato">Vibrato</system:String>
  <system:String x:Key="notedefaults.vibrato.autominlength">Minimum Length</system:String>
  <system:String x:Key="notedefaults.vibrato.autotoggle">Automatic Vibrato by Length</system:String>
  <system:String x:Key="notedefaults.vibrato.depth">Depth</system:String>
  <system:String x:Key="notedefaults.vibrato.drift">Drift</system:String>
  <system:String x:Key="notedefaults.vibrato.in">Fade In</system:String>
  <system:String x:Key="notedefaults.vibrato.length">Length</system:String>
  <system:String x:Key="notedefaults.vibrato.out">Fade Out</system:String>
  <system:String x:Key="notedefaults.vibrato.period">Period</system:String>
  <system:String x:Key="notedefaults.vibrato.shift">Shift</system:String>
  <system:String x:Key="notedefaults.vibrato.vollink">Volume Link</system:String>

  <system:String x:Key="noteproperty">Note Properties</system:String>
  <system:String x:Key="noteproperty.apply">Apply</system:String>
  <system:String x:Key="noteproperty.basic">Basic</system:String>
  <system:String x:Key="noteproperty.cancel">Cancel</system:String>
  <system:String x:Key="noteproperty.set">Set</system:String>
  <system:String x:Key="noteproperty.setlongnote">Set only on long notes</system:String>
  <system:String x:Key="noteproperty.tone">Tone</system:String>
  <system:String x:Key="noteproperty.vibratoenable">Enable</system:String>

  <system:String x:Key="oto.alias">Alias</system:String>
  <system:String x:Key="oto.color">Color</system:String>
  <system:String x:Key="oto.consonant">Consonant</system:String>
  <system:String x:Key="oto.cutoff">Cutoff</system:String>
  <system:String x:Key="oto.edit.consonant">Set Consonant</system:String>
  <system:String x:Key="oto.edit.cutoff">Set Cutoff</system:String>
  <system:String x:Key="oto.edit.offset">Set Offset</system:String>
  <system:String x:Key="oto.edit.overlap">Set Overlap</system:String>
  <system:String x:Key="oto.edit.preutter">Set Preutter</system:String>
  <system:String x:Key="oto.file">File</system:String>
  <system:String x:Key="oto.offset">Offset</system:String>
  <system:String x:Key="oto.overlap">Overlap</system:String>
  <system:String x:Key="oto.phonetic">Phonetic</system:String>
  <system:String x:Key="oto.prefix">Prefix</system:String>
  <system:String x:Key="oto.preutter">Preutter</system:String>
  <system:String x:Key="oto.set">Set</system:String>
  <system:String x:Key="oto.suffix">Suffix</system:String>

  <system:String x:Key="phoneticassistant.caption">Phonetic Assistant</system:String>
  <system:String x:Key="phoneticassistant.copy">Copy</system:String>

  <system:String x:Key="pianoroll.menu.batch">Batch Edits</system:String>
  <system:String x:Key="pianoroll.menu.batch.running">Running batch edit</system:String>
  <system:String x:Key="pianoroll.menu.lyrics">Lyrics</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.dashtoplus">Replace "-" with "+"</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.edit">Edit Lyrics</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.hiraganatoromaji">Hiragana to Romaji</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.insertslur">Insert slur lyric</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.javcvtocv">Japanese VCV to CV</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.movesuffixtovoicecolor">Move Suffix to VoiceColor</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.removelettersuffix">Remove Letter Suffix</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.removephonetichint">Remove Phonetic Hint</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.removetonesuffix">Remove Tone Suffix</system:String>
  <system:String x:Key="pianoroll.menu.lyrics.romajitohiragana">Romaji to Hiragana</system:String>
  <system:String x:Key="pianoroll.menu.notedefaults">Note Defaults</system:String>
  <system:String x:Key="pianoroll.menu.notes">Notes</system:String>
  <system:String x:Key="pianoroll.menu.notes.addbreath">Add breath</system:String>
  <system:String x:Key="pianoroll.menu.notes.addtaildash">Add tail "-"</system:String>
  <system:String x:Key="pianoroll.menu.notes.addtailrest">Add tail "R"</system:String>
  <system:String x:Key="pianoroll.menu.notes.autolegato">Auto Legato</system:String>
  <system:String x:Key="pianoroll.menu.notes.bakepitch">Convert PITD to pitch control points</system:String>
  <system:String x:Key="pianoroll.menu.notes.clear.vibratos">Clear vibratos</system:String>
  <system:String x:Key="pianoroll.menu.notes.fixoverlap">Fix overlapping notes</system:String>
  <system:String x:Key="pianoroll.menu.notes.hanzitopinyin">Hanzi to pinyin</system:String>
  <system:String x:Key="pianoroll.menu.notes.lengthencrossfade">Lengthen crossfades</system:String>
  <system:String x:Key="pianoroll.menu.notes.loadrenderedpitch">Load rendered pitch</system:String>
  <system:String x:Key="pianoroll.menu.notes.octavedown">Move an octave down</system:String>
  <system:String x:Key="pianoroll.menu.notes.octaveup">Move an octave up</system:String>
  <system:String x:Key="pianoroll.menu.notes.quantize15">Quantize to 1/128</system:String>
  <system:String x:Key="pianoroll.menu.notes.quantize30">Quantize to 1/64</system:String>
  <system:String x:Key="pianoroll.menu.notes.removetaildash">Remove tail "-"</system:String>
  <system:String x:Key="pianoroll.menu.notes.removetailrest">Remove tail "R"</system:String>
  <system:String x:Key="pianoroll.menu.notes.reset.aliases">Reset phoneme aliases</system:String>
  <system:String x:Key="pianoroll.menu.notes.reset.all">Reset notes to default</system:String>
  <system:String x:Key="pianoroll.menu.notes.reset.allparameters">Reset all parameters</system:String>
  <system:String x:Key="pianoroll.menu.notes.reset.exps">Reset all expressions</system:String>
  <system:String x:Key="pianoroll.menu.notes.reset.phonemetimings">Reset phoneme timings</system:String>
  <system:String x:Key="pianoroll.menu.notes.reset.pitchbends">Reset pitch bends</system:String>
  <system:String x:Key="pianoroll.menu.notes.reset.vibratos">Reset vibratos</system:String>
  <system:String x:Key="pianoroll.menu.part">Part</system:String>
  <system:String x:Key="pianoroll.menu.part.legacypluginexp">Legacy Plugin (Experimental)</system:String>
  <system:String x:Key="pianoroll.menu.part.singer">Singer and Oto settings</system:String>
  <system:String x:Key="pianoroll.menu.plugin.openfolder">Open folder</system:String>
  <system:String x:Key="pianoroll.menu.plugin.reload">Reload</system:String>
  <system:String x:Key="pianoroll.menu.reset">Reset</system:String>
  <system:String x:Key="pianoroll.menu.searchnote">Search Note</system:String>
  <system:String x:Key="pianoroll.menu.searchnote.all">Select All</system:String>
  <system:String x:Key="pianoroll.menu.searchnote.close">Close</system:String>
  <system:String x:Key="pianoroll.menu.searchnote.next">Next</system:String>
  <system:String x:Key="pianoroll.menu.searchnote.prev">Prev</system:String>
  <system:String x:Key="pianoroll.toggle.finalpitch">View Final Pitch to Render (R)</system:String>
  <system:String x:Key="pianoroll.toggle.noteparams">View Note Parameters (\)</system:String>
  <system:String x:Key="pianoroll.toggle.phoneme">View Phonemes (O)</system:String>
  <system:String x:Key="pianoroll.toggle.pitch">View Pitch Bend (I)</system:String>
  <system:String x:Key="pianoroll.toggle.snap">Toggle Snap (P)</system:String>
  <system:String x:Key="pianoroll.toggle.snap.auto">Auto</system:String>
  <system:String x:Key="pianoroll.toggle.snap.autotriplet">Auto (triplet)</system:String>
  <system:String x:Key="pianoroll.toggle.tips">View Tips (T)</system:String>
  <system:String x:Key="pianoroll.toggle.tone">Toggle Note Tone (Y)</system:String>
  <system:String x:Key="pianoroll.toggle.vibrato">View Vibrato (U)</system:String>
  <system:String x:Key="pianoroll.toggle.waveform">View Waveform (W)</system:String>
  <system:String x:Key="pianoroll.tool.drawpitch">Draw Pitch Tool (4)
    Left click to draw
    Right click to reset
    Hold Ctrl to select
    Hold Alt to smoothen</system:String>
  <system:String x:Key="pianoroll.tool.drawlinepitch">
    Line Draw Pitch Tool (Shift + 4)
    Left click to draw (draw straight line)
    Right click to reset
    Hold Ctrl to select
    Hold Alt to smoothen
  </system:String>
  <system:String x:Key="pianoroll.tool.eraser">Eraser Tool (3)</system:String>
  <system:String x:Key="pianoroll.tool.knife">Knife Tool (5)</system:String>
  <system:String x:Key="pianoroll.tool.overwritepitch">Overwrite Pitch Tool (Ctrl + 4)
    Left click to draw (overwrites vibrato or mod+)
    Right click to reset
    Hold Ctrl to select
    Hold Alt to smoothen
  </system:String>
  <system:String x:Key="pianoroll.tool.penplus">Pen Plus Tool (Ctrl + 2)
    Left click to draw
    Right click to delete
    Hold Ctrl to select</system:String>
  <system:String x:Key="pianoroll.tool.penv2">Pen Tool (2)
    Left click to draw
    Hold Ctrl to select</system:String>
  <system:String x:Key="pianoroll.tool.selectionv2">Selection Tool (1)</system:String>

  <system:String x:Key="prefs.advanced">Advanced</system:String>
  <system:String x:Key="prefs.advanced.beta">Beta</system:String>
  <system:String x:Key="prefs.advanced.checkupdateonstart">Check for update on start</system:String>
  <system:String x:Key="prefs.advanced.importtempo">When importing tracks, use the tempos of the imported project</system:String>
  <system:String x:Key="prefs.advanced.importtempo.always">Always</system:String>
  <system:String x:Key="prefs.advanced.importtempo.ask">Ask me each time</system:String>
  <system:String x:Key="prefs.advanced.importtempo.never">Never</system:String>
  <system:String x:Key="prefs.advanced.lyricshelper">Lyrics Helper</system:String>
  <system:String x:Key="prefs.advanced.lyricshelper.brackets">Lyrics Helper Adds Brackets</system:String>
  <system:String x:Key="prefs.advanced.rememberfiletypes">Remember these file types in "Open Recent"</system:String>
  <system:String x:Key="prefs.advanced.resamplerlogging">Resampler Logging</system:String>
  <system:String x:Key="prefs.advanced.resamplerlogging.warn">Stores resampler output in log files. This option slows down UI and rendering.</system:String>
  <system:String x:Key="prefs.advanced.stable">Stable</system:String>
  <system:String x:Key="prefs.advanced.vlabelerpath">vLabeler Path</system:String>
  <system:String x:Key="prefs.appearance">Appearance</system:String>
  <system:String x:Key="prefs.appearance.degree">Scale degree display style</system:String>
  <system:String x:Key="prefs.appearance.degree.numbered">Numbered (1 2 3 4 5 6 7)</system:String>
  <system:String x:Key="prefs.appearance.degree.off">Off</system:String>
  <system:String x:Key="prefs.appearance.degree.solfege">Solfège (do re mi fa sol la ti)</system:String>
  <system:String x:Key="prefs.appearance.lang">Language</system:String>
  <system:String x:Key="prefs.appearance.showghostnotes">Show other tracks' notes on piano roll</system:String>
  <system:String x:Key="prefs.appearance.showicon">Show icon on piano roll</system:String>
  <system:String x:Key="prefs.appearance.showportrait">Show portrait on piano roll</system:String>
  <system:String x:Key="prefs.appearance.sortorder">Singer name display language</system:String>
  <system:String x:Key="prefs.appearance.theme">Theme</system:String>
  <system:String x:Key="prefs.appearance.theme.dark">Dark</system:String>
  <system:String x:Key="prefs.appearance.theme.light">Light</system:String>
  <system:String x:Key="prefs.appearance.trackcolor">Use track color in UI</system:String>
  <system:String x:Key="prefs.cache">Cache</system:String>
  <system:String x:Key="prefs.cache.clearonquit">Clear cache on quit</system:String>
  <system:String x:Key="prefs.cache.diffsingertensorcache">DiffSinger Tensor Cache</system:String>
  <system:String x:Key="prefs.caption">Preferences</system:String>
  <system:String x:Key="prefs.note.restart">Note: please restart OpenUtau after changing this item.</system:String>
  <system:String x:Key="prefs.off">Off</system:String>
  <system:String x:Key="prefs.on">On</system:String>
  <system:String x:Key="prefs.otoeditor">Oto Editor</system:String>
  <system:String x:Key="prefs.otoeditor.select">Default Oto Editor</system:String>
  <system:String x:Key="prefs.otoeditor.setparampath">setParam Path</system:String>
  <system:String x:Key="prefs.paths">Paths</system:String>
  <system:String x:Key="prefs.paths.addlsinger">Additional Singer Path</system:String>
  <system:String x:Key="prefs.paths.addlsinger.install">Install to Additional Singer Path</system:String>
  <system:String x:Key="prefs.paths.loaddeepfolders">Load all depth folders</system:String>
  <system:String x:Key="prefs.paths.reset">Reset</system:String>
  <system:String x:Key="prefs.paths.select">Select</system:String>
  <system:String x:Key="prefs.penplus">Set Pen Plus Tool as Default</system:String>
  <system:String x:Key="prefs.playback">Playback</system:String>
  <system:String x:Key="prefs.playback.autoscroll">Auto-Scroll</system:String>
  <system:String x:Key="prefs.playback.autoscrollmode">Auto-Scroll Mode</system:String>
  <system:String x:Key="prefs.playback.autoscrollmode.pagescroll">Page Scroll</system:String>
  <system:String x:Key="prefs.playback.autoscrollmode.stationarycursor">Stationary Cursor</system:String>
  <system:String x:Key="prefs.playback.backend">Audio Backend</system:String>
  <system:String x:Key="prefs.playback.backend.auto">Automatic</system:String>
  <system:String x:Key="prefs.playback.backend.mini">MiniAudio</system:String>
  <system:String x:Key="prefs.playback.cursorposition">Auto-Scroll Margin</system:String>
  <system:String x:Key="prefs.playback.device">Playback Device</system:String>
  <system:String x:Key="prefs.playback.lockstarttime">On Pausing</system:String>
  <system:String x:Key="prefs.playback.lockstarttime.off">Do nothing</system:String>
  <system:String x:Key="prefs.playback.lockstarttime.on">Move cursor and view position back to where you started playing</system:String>
  <system:String x:Key="prefs.playback.lockstarttime.onlycursor">Move only cursor back to where you started playing</system:String>
  <system:String x:Key="prefs.playback.test">Test</system:String>
  <system:String x:Key="prefs.rendering">Rendering</system:String>
  <system:String x:Key="prefs.rendering.defaultrenderer">Default renderer (for classic voicebanks)</system:String>
  <system:String x:Key="prefs.rendering.diffsingerdepth">DiffSinger Render Depth</system:String>
  <system:String x:Key="prefs.rendering.diffsingersteps">DiffSinger Render Steps</system:String>
  <system:String x:Key="prefs.rendering.onnxgpu">GPU</system:String>
  <system:String x:Key="prefs.rendering.onnxrunner">Machine Learning Runner</system:String>
  <system:String x:Key="prefs.rendering.phasecomp">Phase Compensation</system:String>
  <system:String x:Key="prefs.rendering.prerender">Pre-render</system:String>
  <system:String x:Key="prefs.rendering.resampler">Resampler</system:String>
  <system:String x:Key="prefs.rendering.resampler.morewarn">
    Warning: moresampler is not fully supported. It may be slow and cause high CPU usage. If you insist, please:
    1. Set "resampler-compatibility" to "on" in moreconfig.txt.
    2. Set "auto-update-llsm-mrq" to "off" in moreconfig.txt.
    3. Patiently wait for moresampler to generate missing llsm files.
  </system:String>
  <system:String x:Key="prefs.rendering.resampler.note">
    Note: to use external resamplers, please add the resampler DLL or EXE file in the Resamplers folder in the OpenUtau install path and choose it in Preferences.
  </system:String>
  <system:String x:Key="prefs.rendering.skipmuted">Skip muted tracks</system:String>
  <system:String x:Key="prefs.rendering.threads.cpuwarn">
    Warning: too many render threads may cause OpenUtau to run slowly.
  </system:String>
  <system:String x:Key="prefs.rendering.threads.numthreads">Maximum Render Threads</system:String>
  <system:String x:Key="prefs.rendering.wavtool">Wavtool</system:String>

  <system:String x:Key="progress.loadingsingers">Loading Singers...</system:String>
  <system:String x:Key="progress.saved">Project saved. {0}</system:String>
  <system:String x:Key="progress.waitingrendering">Waiting Rendering</system:String>

  <system:String x:Key="singers.caption">Singers</system:String>
  <system:String x:Key="singers.editoto.editinsetparam">Edit In setParam</system:String>
  <system:String x:Key="singers.editoto.editinvlabeler">Edit In vLabeler</system:String>
  <system:String x:Key="singers.editoto.gotosource">Goto Source File</system:String>
  <system:String x:Key="singers.editoto.regenfrq">Regenerate FRQ</system:String>
  <system:String x:Key="singers.editoto.regenfrq.regenerating">Regenerating FRQ</system:String>
  <system:String x:Key="singers.editoto.reset">Reset Otos</system:String>
  <system:String x:Key="singers.editoto.save">Save Otos</system:String>
  <system:String x:Key="singers.editoto.searchalias">Search Alias</system:String>
  <system:String x:Key="singers.editoto.setsetparampath">Download setParam (v4.0b or higher) from http://nwp8861.blog92.fc2.com/ and set setParam path in Preferences first!</system:String>
  <system:String x:Key="singers.editoto.setvlabelerpath">Download vLabeler (1.0.0-beta1 or higher) from https://github.com/sdercolin/vlabeler and set vLabeler path in Preferences first!</system:String>
  <system:String x:Key="singers.errorreport">Generate Singer Error Report</system:String>
  <system:String x:Key="singers.location">Location</system:String>
  <system:String x:Key="singers.otoview.moveleft">Move Left</system:String>
  <system:String x:Key="singers.otoview.moveright">Move Right</system:String>
  <system:String x:Key="singers.otoview.selectnext">Select Next</system:String>
  <system:String x:Key="singers.otoview.selectprev">Select Prev</system:String>
  <system:String x:Key="singers.otoview.showall">Show All</system:String>
  <system:String x:Key="singers.otoview.zoomin">Zoom In</system:String>
  <system:String x:Key="singers.otoview.zoomout">Zoom Out</system:String>
  <system:String x:Key="singers.playsample">Play sample</system:String>
  <system:String x:Key="singers.publish">Publish Singer</system:String>
  <system:String x:Key="singers.publish.description">Create an optimized zip package of your singer for distribution.</system:String>
  <system:String x:Key="singers.publish.ignoretypes">Ignore these file types during packaging (gitignore syntax):</system:String>
  <system:String x:Key="singers.publish.publish">Publish</system:String>
  <system:String x:Key="singers.publish.useignore"> Use file type ignoring</system:String>
  <system:String x:Key="singers.readme">Open readme.txt</system:String>
  <system:String x:Key="singers.readme.notfound">readme.txt not found.</system:String>
  <system:String x:Key="singers.refresh">Refresh</system:String>
  <system:String x:Key="singers.setdefaultphonemizer">Set Default Phonemizer</system:String>
  <system:String x:Key="singers.setencoding">Set Encoding</system:String>
  <system:String x:Key="singers.setimage">Set Icon</system:String>
  <system:String x:Key="singers.setportrait">Set Portrait</system:String>
  <system:String x:Key="singers.setsingertype">Set Singer Type</system:String>
  <system:String x:Key="singers.subbanks.cancel">Cancel</system:String>
  <system:String x:Key="singers.subbanks.clear">Clear</system:String>
  <system:String x:Key="singers.subbanks.color">Color</system:String>
  <system:String x:Key="singers.subbanks.color.add">Add Color</system:String>
  <system:String x:Key="singers.subbanks.color.remove">Remove Color</system:String>
  <system:String x:Key="singers.subbanks.color.rename">Rename</system:String>
  <system:String x:Key="singers.subbanks.edit">Edit Subbanks</system:String>
  <system:String x:Key="singers.subbanks.export">Export prefix.map</system:String>
  <system:String x:Key="singers.subbanks.import">Import prefix.map</system:String>
  <system:String x:Key="singers.subbanks.reset">Reset</system:String>
  <system:String x:Key="singers.subbanks.save">Save</system:String>
  <system:String x:Key="singers.subbanks.selectall">Select All</system:String>
  <system:String x:Key="singers.subbanks.set">Set</system:String>
  <system:String x:Key="singers.subbanks.tone">Tone</system:String>
  <system:String x:Key="singers.subbanks.toneranges">Tone Ranges</system:String>
  <system:String x:Key="singers.usefilename">Use filename as alias</system:String>
  <system:String x:Key="singers.visitwebsite">Visit Website</system:String>

  <system:String x:Key="singersetup.archivefileencoding">Archive File Encoding</system:String>
  <system:String x:Key="singersetup.archivefileencoding.prompt">Choose an encoding that make file names look right.</system:String>
  <system:String x:Key="singersetup.back">Back</system:String>
  <system:String x:Key="singersetup.install">Install</system:String>
  <system:String x:Key="singersetup.missinginfo">Please add the following settings to this voicebank's character.yaml.</system:String>
  <system:String x:Key="singersetup.next">Next</system:String>
  <system:String x:Key="singersetup.singertype">Singer Type</system:String>
  <system:String x:Key="singersetup.textfileencoding">Text File Encoding</system:String>
  <system:String x:Key="singersetup.textfileencoding.prompt">Choose an encoding that make file contents look right.</system:String>

  <system:String x:Key="tip.aliasbox">Override Alias</system:String>
  <system:String x:Key="tip.exps">Left Button Draw: Set expressions
Right Button Draw: Reset expressions</system:String>
  <system:String x:Key="tip.exps.notsupported">Expression not supported by renderer</system:String>
  <system:String x:Key="tip.lyricbox.next">Tab: Next Note</system:String>
  <system:String x:Key="tip.lyricbox.prev">Shift+Tab: Previous Note</system:String>
  <system:String x:Key="tip.notes.basics">Selection Tool
    Box Select: Select notes
    Ctrl + Box Select: Select more notes
    Up/Down: Transpose selected notes
    Ctrl + Up/Down: Transpose selected notes by octave
Pen Tool
    Left Button Draw: Add note
    Right Click: Remove note
    Right Button Draw: Remove multiple notes
General
    T: Toggle tips
    Drag Note: Move note
    Drag End of Note: Resize note
    Alt + Drag End of Note: Resize neighbouring notes
    Space: Play</system:String>
  <system:String x:Key="tip.notes.zoomx">◀ Scroll here to zoom horizontally ▶</system:String>
  <system:String x:Key="tip.notes.zoomy">Scroll here to zoom vertically ▶</system:String>

  <system:String x:Key="tracks.duplicate">Duplicate Track</system:String>
  <system:String x:Key="tracks.duplicatesettings">Duplicate Track Settings</system:String>
  <system:String x:Key="tracks.installsinger">Install singer</system:String>
  <system:String x:Key="tracks.more">More</system:String>
  <system:String x:Key="tracks.movedown">Move Down</system:String>
  <system:String x:Key="tracks.moveup">Move Up</system:String>
  <system:String x:Key="tracks.mute">Mute</system:String>
  <system:String x:Key="tracks.mute.allothers">Mute all others</system:String>
  <system:String x:Key="tracks.mute.only">Mute this only</system:String>
  <system:String x:Key="tracks.mute.unmuteall">Unmute all</system:String>
  <system:String x:Key="tracks.opensingers">Open singers location</system:String>
  <system:String x:Key="tracks.openaddsingers">Open additional singers location</system:String>
  <system:String x:Key="tracks.remove">Remove</system:String>
  <system:String x:Key="tracks.rename">Rename track</system:String>
  <system:String x:Key="tracks.selectrenderer">Select Renderer</system:String>
  <system:String x:Key="tracks.selectsinger">Select Singer</system:String>
  <system:String x:Key="tracks.solo">Solo</system:String>
  <system:String x:Key="tracks.solo.add">Solo additionally (which not removes solo from other tracks)</system:String>
  <system:String x:Key="tracks.solo.only">Solo this only (which removes solo from other tracks)</system:String>
  <system:String x:Key="tracks.solo.unsoloall">Unsolo all</system:String>
  <system:String x:Key="tracks.trackcolor">Change track color</system:String>
  <system:String x:Key="tracks.tracksettings">Track Settings</system:String>

  <FontFamily x:Key="ui.fontfamily">Segoe UI,San Francisco,Helvetica Neue</FontFamily>

  <system:String x:Key="updater.caption">Check for Update</system:String>
  <system:String x:Key="updater.description">Open singing synthesis platform</system:String>
  <system:String x:Key="updater.github">GitHub</system:String>
  <system:String x:Key="updater.status.available">Update v{0} available!</system:String>
  <system:String x:Key="updater.status.checking">Checking for updates...</system:String>
  <system:String x:Key="updater.status.notavailable">Up to date</system:String>
  <system:String x:Key="updater.status.unknown">Unable to check update</system:String>
  <system:String x:Key="updater.update">Update</system:String>

  <system:String x:Key="warning">Warning</system:String>
  <system:String x:Key="warning.asciipath">Your OpenUtau home path "{0}" contains non-ASCII character. Exe resamplers may not work.</system:String>
  <system:String x:Key="warning.renderer">No settings for this renderer.</system:String>
</ResourceDictionary>