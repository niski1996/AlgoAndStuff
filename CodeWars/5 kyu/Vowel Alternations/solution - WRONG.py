# Exclude 'y' from vowels since it can't make up its mind if it's a vowel
from itertools import groupby
vowels = 'aeiou'


def find_solutions(words):
    solutions = []
    pos = map(vovelPosition, words)
    zipped = list(zip(words, pos))
    zipped.sort(key=lambda x: x[1])
    counter = 0
    print(len(zipped))

    print(zipped)
    jumpflag = 0  # prevent overlooping identical word solutions
    for index,wordObj in enumerate(zipped):
        if index!=0 and jumpflag==0:
            if wordObj[1]==zipped[index-1][1]:
                counter+=1
            else:
                counter=0
        jumpflag=0
        if counter==4:
            jumpflag = 1
            counter=0
            solutions.append(sorted(list(map(lambda x: x[0] , zipped[index-4:index+1]))))

    return solutions



def vovelPosition(word):
    ar=""
    for index,letter in enumerate(word):
        if letter in vowels:
            ar+=str(index)
    return ar+'~'+str(len(word))

########################    EXAMPLE OF VALID    ###############
def find_solutions2(words):
    words = set(words)
    solutions = set()

    for word in words:
        for i, c in enumerate(word):
            if c in 'aeiou':
                variations = frozenset(''.join(word[:i] + v + word[i + 1:]) for v in 'aeiou')
                if variations <= words:
                    solutions.add(variations)

    return sorted(sorted(s) for s in solutions)
##################################################################

a=['an', 'are', 'as', 'bad', 'bag', 'bagged', 'bagging', 'bags', 'ball', 'balled', 'balling', 'balls', 'band', 'bands', 'bat', 'bats', 'batty', 'bed', 'beg', 'begged', 'begging', 'begs', 'bell', 'belled', 'belling', 'bells', 'bend', 'bends', 'bet', 'bets', 'betty', 'bid', 'big', 'bigged', 'bigging', 'bigs', 'bill', 'billed', 'billing', 'bills', 'bind', 'binds', 'bit', 'bits', 'bitty', 'blander', 'blender', 'blinder', 'blonder', 'blunder', 'bod', 'bog', 'bogged', 'bogging', 'bogs', 'boll', 'bolled', 'bolling', 'bolls', 'bond', 'bonds', 'bot', 'bots', 'botty', 'bud', 'bug', 'bugged', 'bugging', 'bugs', 'bull', 'bulled', 'bulling', 'bulls', 'bund', 'bunds', 'but', 'buts', 'butty', 'call', 'care', 'cares', 'cate', 'cates', 'cell', 'cere', 'ceres', 'cete', 'cetes', 'cill', 'cire', 'cires', 'cite', 'cites', 'clack', 'clacked', 'clacking', 'clacks', 'cleck', 'clecked', 'clecking', 'clecks', 'click', 'clicked', 'clicking', 'clicks', 'clock', 'clocked', 'clocking', 'clocks', 'cluck', 'clucked', 'clucking', 'clucks', 'coll', 'core', 'cores', 'cote', 'cotes', 'cull', 'cure', 'cures', 'cute', 'cutes', 'dab', 'dacker', 'dackers', 'dae', 'dan', 'dans', 'deb', 'decker', 'deckers', 'dee', 'den', 'dens', 'dib', 'dicker', 'dickers', 'die', 'din', 'dins', 'dob', 'docker', 'dockers', 'doe', 'don', 'dons', 'dub', 'ducker', 'duckers', 'due', 'dun', 'duns', 'en', 'ere', 'es', 'fags', 'fan', 'fand', 'fegs', 'fen', 'fend', 'figs', 'fin', 'find', 'fogs', 'fon', 'fond', 'fugs', 'fun', 'fund', 'gae', 'gaes', 'gally', 'gat', 'gee', 'gees', 'gelly', 'get', 'gie', 'gies', 'gilly', 'git', 'goe', 'goes', 'golly', 'got', 'gue', 'gues', 'gully', 'gut', 'hack', 'hacks', 'haed', 'hallo', 'halloed', 'halloing', 'hallos', 'hap', 'haps', 'hat', 'hats', 'heck', 'hecks', 'heed', 'hello', 'helloed', 'helloing', 'hellos', 'hep', 'heps', 'het', 'hets', 'hick', 'hicks', 'hied', 'hillo', 'hilloed', 'hilloing', 'hillos', 'hip', 'hips', 'hit', 'hits', 'hock', 'hocks', 'hoed', 'hollo', 'holloed', 'holloing', 'hollos', 'hop', 'hops', 'hot', 'hots', 'huck', 'hucks', 'hued', 'hullo', 'hulloed', 'hulloing', 'hullos', 'hup', 'hups', 'hut', 'huts', 'in', 'ire', 'is', 'lag', 'lagged', 'lagger', 'laggers', 'lagging', 'lags', 'lang', 'lare', 'last', 'leg', 'legged', 'legger', 'leggers', 'legging', 'legs', 'leng', 'lere', 'lest', 'lig', 'ligged', 'ligger', 'liggers', 'ligging', 'ligs', 'ling', 'lire', 'list', 'log', 'logged', 'logger', 'loggers', 'logging', 'logs', 'long', 'lore', 'lost', 'lug', 'lugged', 'lugger', 'luggers', 'lugging', 'lugs', 'lung', 'lure', 'lust', 'ma', 'mall', 'malls', 'mang', 'mare', 'mares', 'mase', 'mases', 'mass', 'massed', 'masses', 'massing', 'massy', 'mate', 'mates', 'me', 'mell', 'mells', 'meng', 'mere', 'meres', 'mese', 'meses', 'mess', 'messed', 'messes', 'messing', 'messy', 'mete', 'metes', 'mi', 'mill', 'mills', 'minas', 'mines', 'ming', 'minis', 'minos', 'minus', 'mire', 'mires', 'mise', 'mises', 'miss', 'missed', 'misses', 'missing', 'missy', 'mite', 'mites', 'mo', 'moa', 'moe', 'moi', 'moll', 'molls', 'mong', 'moo', 'more', 'mores', 'mose', 'moses', 'moss', 'mossed', 'mosses', 'mossing', 'mossy', 'mote', 'motes', 'mou', 'mu', 'mull', 'mulls', 'mung', 'mure', 'mures', 'muse', 'muses', 'muss', 'mussed', 'musses', 'mussing', 'mussy', 'mute', 'mutes', 'nab', 'nabs', 'nat', 'neb', 'nebs', 'net', 'nib', 'nibs', 'nit', 'nob', 'nobs', 'not', 'nub', 'nubs', 'nut', 'on', 'ore', 'os', 'pack', 'packs', 'pall', 'pans', 'pant', 'pants', 'pap', 'papped', 'papping', 'pappy', 'paps', 'pat', 'pats', 'patted', 'patter', 'patters', 'patting', 'peck', 'pecks', 'pell', 'pens', 'pent', 'pents', 'pep', 'pepped', 'pepping', 'peppy', 'peps', 'pet', 'pets', 'petted', 'petter', 'petters', 'petting', 'pick', 'picks', 'pill', 'pins', 'pint', 'pints', 'pip', 'pipped', 'pipping', 'pippy', 'pips', 'pit', 'pits', 'pitted', 'pitter', 'pitters', 'pitting', 'pock', 'pocks', 'poll', 'pons', 'pont', 'ponts', 'pop', 'popped', 'popping', 'poppy', 'pops', 'pot', 'pots', 'potted', 'potter', 'potters', 'potting', 'puck', 'pucks', 'pull', 'puns', 'punt', 'punts', 'pup', 'pupped', 'pupping', 'puppy', 'pups', 'put', 'puts', 'putted', 'putter', 'putters', 'putting', 'rack', 'racked', 'racking', 'racks', 'rad', 'rads', 'ram', 'rams', 'rat', 'rats', 'ratted', 'ratting', 'reck', 'recked', 'recking', 'recks', 'red', 'reds', 'rem', 'rems', 'ret', 'rets', 'retted', 'retting', 'rick', 'ricked', 'ricking', 'ricks', 'rid', 'rids', 'rim', 'rims', 'rit', 'rits', 'ritted', 'ritting', 'rock', 'rocked', 'rocking', 'rocks', 'rod', 'rods', 'rom', 'roms', 'rot', 'rots', 'rotted', 'rotting', 'ruck', 'rucked', 'rucking', 'rucks', 'rud', 'ruds', 'rum', 'rums', 'rut', 'ruts', 'rutted', 'rutting', 'san', 'sans', 'saps', 'sass', 'sen', 'sens', 'seps', 'sess', 'shat', 'shet', 'shit', 'shot', 'shut', 'sin', 'sins', 'sips', 'siss', 'snab', 'snabs', 'sneb', 'snebs', 'snib', 'snibs', 'snob', 'snobs', 'snub', 'snubs', 'son', 'sons', 'sops', 'soss', 'sun', 'suns', 'sups', 'suss', 'tag', 'tags', 'tan', 'tane', 'tans', 'teg', 'tegs', 'ten', 'tene', 'tens', 'tig', 'tigs', 'tin', 'tine', 'tins', 'tog', 'togs', 'ton', 'tone', 'tons', 'track', 'tracked', 'tracking', 'tracks', 'treck', 'trecked', 'trecking', 'trecks', 'trick', 'tricked', 'tricking', 'tricks', 'trock', 'trocked', 'trocking', 'trocks', 'truck', 'trucked', 'trucking', 'trucks', 'tug', 'tugs', 'tun', 'tune', 'tuns', 'un', 'ure', 'us']
print(sorted(find_solutions(a)))
print(find_solutions2(a))