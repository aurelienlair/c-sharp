class Phrase
  VERSION = 3

  def initialize(sentence)
    @sentence = sentence
  end

  def word_count
    word_counter = Hash.new(0)
    @sentence.split(/[^\w']+/).each do |word|
      parsed_word = word.downcase.gsub(/^'(\w+)'$/, '\1')
      word_counter[parsed_word] += 1
    end
    word_counter
  end
end